import re
import sys
import os

def extract_table_names_from_mapping(mapping_file):
    """Extract table names from the mapping file."""
    table_names = []
    with open(mapping_file, 'r', encoding='utf-8') as f:
        for line in f:
            # Skip lines that are comments or empty
            if line.strip().startswith('#') or not line.strip():
                continue
            # Extract old table name (format: number. OLD_TABLE => NewModel)
            match = re.search(r'^\d+\.\s+(\w+)\s+=>', line)
            if match:
                table_names.append(match.group(1))
    return table_names

def extract_field_names(sql_content, target_tables=None):
    """
    Extract field names from SQL content, optionally filtering by table names.
    If target_tables is provided, only extract fields from those tables.
    """
    # Regular expression to find CREATE TABLE statements and their contents
    create_table_pattern = r"CREATE\s+TABLE\s+(?:IF\s+NOT\s+EXISTS\s+)?[`\"\[]?(\w+)[`\"\]]?\s*\((.*?)\)(?:\s*ENGINE\s*=.*?)?;"
    
    # Regular expression to extract field names from CREATE TABLE contents
    field_pattern = r"[`\"\[]?(\w+)[`\"\]]?\s+(?:\w+)(?:\(.*?\))?(?:.*?)(?:,|$)"
    
    # Find all CREATE TABLE statements
    tables = re.findall(create_table_pattern, sql_content, re.IGNORECASE | re.DOTALL)
    
    # Dictionary to store table statistics
    table_stats = {}
    
    # Set to store unique field names
    unique_fields = set()
    
    # Process each table
    for table_name, table_content in tables:
        # If target_tables is provided, only process tables in the list
        if target_tables and table_name not in target_tables:
            continue
            
        # Initialize statistics for this table
        table_stats[table_name] = []
            
        # Extract field definitions (excluding PRIMARY KEY, FOREIGN KEY, etc.)
        lines = table_content.split(',')
        for line in lines:
            line = line.strip()
            # Skip constraint definitions
            if re.match(r"(?:PRIMARY|FOREIGN|UNIQUE)\s+KEY", line, re.IGNORECASE) or \
               re.match(r"CONSTRAINT", line, re.IGNORECASE) or \
               re.match(r"KEY", line, re.IGNORECASE) or \
               re.match(r"INDEX", line, re.IGNORECASE):
                continue
                
            # Extract field name
            field_match = re.match(field_pattern, line, re.IGNORECASE)
            if field_match:
                field_name = field_match.group(1)
                unique_fields.add(field_name)
                table_stats[table_name].append(field_name)
    
    return sorted(list(unique_fields)), table_stats

def try_read_file(file_path):
    """Try to read file with different encodings."""
    encodings = ['utf-8', 'windows-1256', 'iso-8859-1', 'cp1252', 'arabic']
    
    for encoding in encodings:
        try:
            with open(file_path, 'r', encoding=encoding) as f:
                return f.read()
        except UnicodeDecodeError:
            continue
    
    # If all encodings fail, try binary read and decode
    try:
        with open(file_path, 'rb') as f:
            content = f.read()
            # Try to decode as windows-1256 with error handling
            return content.decode('windows-1256', errors='replace')
    except Exception as e:
        raise Exception(f"Could not read file with any encoding. Error: {e}")

def process_sql_files(sql_dir, target_tables=None):
    """Process all SQL files in directory and extract field names."""
    unique_fields = set()
    all_table_stats = {}
    
    for root, _, files in os.walk(sql_dir):
        for file in files:
            if file.endswith('.sql'):
                file_path = os.path.join(root, file)
                try:
                    sql_content = try_read_file(file_path)
                    
                    # Extract fields and stats from this file
                    fields, table_stats = extract_field_names(sql_content, target_tables)
                    unique_fields.update(fields)
                    all_table_stats.update(table_stats)
                    
                except Exception as e:
                    print(f"Error processing {file_path}: {e}")
    
    return sorted(list(unique_fields)), all_table_stats

def main():
    if len(sys.argv) < 2:
        print("Usage: python extract_fields.py <sql_file_or_dir> [mapping_file]")
        sys.exit(1)
    
    sql_path = sys.argv[1]
    mapping_file = sys.argv[2] if len(sys.argv) > 2 else None
    
    target_tables = None
    if mapping_file:
        try:
            target_tables = extract_table_names_from_mapping(mapping_file)
            print(f"Extracted {len(target_tables)} table names from mapping file")
        except Exception as e:
            print(f"Error processing mapping file: {e}")
            sys.exit(1)
    
    try:
        # Check if path is a file or directory
        if os.path.isfile(sql_path):
            sql_content = try_read_file(sql_path)
            field_names, table_stats = extract_field_names(sql_content, target_tables)
        elif os.path.isdir(sql_path):
            field_names, table_stats = process_sql_files(sql_path, target_tables)
        else:
            print(f"Error: Path '{sql_path}' does not exist.")
            sys.exit(1)
        
        print("\n=== Statistics ===")
        print(f"Total number of tables: {len(table_stats)}")
        print(f"Total unique fields: {len(field_names)}")
        
        # Calculate average fields per table
        total_fields = sum(len(fields) for fields in table_stats.values())
        avg_fields = total_fields / len(table_stats) if table_stats else 0
        print(f"Average fields per table: {avg_fields:.2f}")
        
        # Find most common fields
        field_frequency = {}
        for fields in table_stats.values():
            for field in fields:
                field_frequency[field] = field_frequency.get(field, 0) + 1
                
        print("\n=== Most Common Fields ===")
        common_fields = sorted(field_frequency.items(), key=lambda x: x[1], reverse=True)[:10]
        for field, count in common_fields:
            print(f"{field}: appears in {count} tables")
        
        print("\n=== Unique Field Names ===")
        for index, field in enumerate(field_names, 1):
            print(f"{index}. {field}")

        # Save results to file
        output_file = 'extracted_sql_fields.txt'
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write("=== Statistics ===\n")
            f.write(f"Total number of tables: {len(table_stats)}\n")
            f.write(f"Total unique fields: {len(field_names)}\n")
            f.write(f"Average fields per table: {avg_fields:.2f}\n\n")
            
            f.write("=== Most Common Fields ===\n")
            for field, count in common_fields:
                f.write(f"{field}: appears in {count} tables\n")
            
            f.write("\n=== Unique Field Names ===\n")
            for index, field in enumerate(field_names, 1):
                f.write(f"{index}. {field}\n")
                
        print(f"\nResults saved to '{output_file}'")
        
    except FileNotFoundError:
        print(f"Error: File '{sql_path}' not found.")
        sys.exit(1)
    except Exception as e:
        print(f"Error: {e}")
        sys.exit(1)

if __name__ == "__main__":
    main() 
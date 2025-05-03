import json
import sys

def extract_table_info(json_file, table_names):
    try:
        with open(json_file, 'r') as f:
            # Try to read the file as a single JSON object first
            try:
                data = json.load(f)
            except json.JSONDecodeError:
                # If that fails, try to read line by line
                f.seek(0)
                content = f.read()
                # Remove any trailing commas before closing braces/brackets
                content = content.replace(',]', ']').replace(',}', '}')
                # Try to parse the cleaned content
                data = json.loads(content)
        
        result = []
        # Convert comma-separated string to list if needed
        if isinstance(table_names, str):
            table_names = [name.strip() for name in table_names.split(',')]
        
        # Handle both array and object structures
        if isinstance(data, dict):
            # If data is a dictionary, check each key
            for table_name, table_info in data.items():
                if table_name in table_names:
                    result.append({"name": table_name, **table_info})
        elif isinstance(data, list):
            # If data is a list, check each item's name
            for table in data:
                if isinstance(table, dict) and table.get('name') in table_names:
                    result.append(table)
        
        return json.dumps(result, indent=2)
    except Exception as e:
        return f"Error processing file: {str(e)}"

if __name__ == '__main__':
    if len(sys.argv) != 3:
        print("Usage: python parse_tables.py <json_file> <table_names>")
        print("Example: python parse_tables.py output.json 'S_CMPNY,S_BRN'")
        sys.exit(1)
        
    json_file = sys.argv[1]
    table_names = sys.argv[2]
    
    print(extract_table_info(json_file, table_names)) 
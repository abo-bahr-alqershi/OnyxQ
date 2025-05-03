import json
import os
from collections import defaultdict, Counter

def analyze_relationships(json_file):
    """Analyze table relationships in a JSON file containing database structure"""
    
    # Check file size
    file_size = os.path.getsize(json_file)
    print(f"JSON file size: {file_size / (1024 * 1024):.2f} MB")
    
    # Read the JSON file
    try:
        with open(json_file, 'r') as f:
            data = json.load(f)
        print(f"Successfully loaded JSON file")
    except json.JSONDecodeError:
        print("Error: Invalid JSON format")
        return
    except Exception as e:
        print(f"Error reading file: {str(e)}")
        return
    
    # Initialize counters
    total_tables = 0
    tables_with_foreign_keys = 0
    tables_with_primary_keys = 0
    total_foreign_keys = 0
    total_relationships = 0
    relationships = defaultdict(list)
    referenced_tables = defaultdict(int)
    referencing_tables = defaultdict(int)
    table_names = set()
    # Track detailed relationships
    detailed_relationships = defaultdict(lambda: defaultdict(int))
    
    # Process the data based on structure
    if isinstance(data, dict):
        # The JSON contains table names as keys
        tables = data
    elif isinstance(data, list):
        # The JSON contains an array of table objects
        tables = {table.get('name', f"Unknown_{i}"): table for i, table in enumerate(data)}
    else:
        print("Error: Unexpected JSON structure")
        return
    
    # Count all tables
    total_tables = len(tables)
    table_names = set(tables.keys())
    
    # Analyze relationships
    for table_name, table_data in tables.items():
        # Handle case where table data could be directly in list or within a sub-object
        if isinstance(table_data, dict):
            foreign_keys = table_data.get('foreign_keys', [])
            primary_keys = table_data.get('primary_keys', [])
        else:
            foreign_keys = table_data.get('foreign_keys', []) if hasattr(table_data, 'get') else []
            primary_keys = table_data.get('primary_keys', []) if hasattr(table_data, 'get') else []
        
        # Count tables with foreign keys
        if foreign_keys:
            tables_with_foreign_keys += 1
            referencing_tables[table_name] = len(foreign_keys)
            
            # Add to total count
            total_foreign_keys += len(foreign_keys)
            
            # Record relationships
            for fk in foreign_keys:
                if isinstance(fk, dict) and 'references_table' in fk:
                    referenced_table = fk['references_table']
                    relationships[table_name].append(referenced_table)
                    referenced_tables[referenced_table] += 1
                    total_relationships += 1
                    
                    # Track detailed relationships (which table references which and how many times)
                    detailed_relationships[table_name][referenced_table] += 1
        
        # Count tables with primary keys
        if primary_keys:
            tables_with_primary_keys += 1
    
    # Generate report
    print("\n===== DATABASE RELATIONSHIP ANALYSIS =====")
    print(f"Total tables: {total_tables}")
    print(f"Tables with primary keys: {tables_with_primary_keys} ({tables_with_primary_keys/total_tables*100:.2f}%)")
    print(f"Tables with foreign keys: {tables_with_foreign_keys} ({tables_with_foreign_keys/total_tables*100:.2f}%)")
    print(f"Total foreign key relationships: {total_relationships}")
    print(f"Average foreign keys per table: {total_foreign_keys/total_tables:.2f}")
    
    # Most referenced tables
    print("\n----- MOST REFERENCED TABLES -----")
    most_referenced = sorted(referenced_tables.items(), key=lambda x: x[1], reverse=True)
    for table, count in most_referenced[:10]:  # Top 10
        print(f"{table}: {count} references")
    
    # Tables with most foreign keys
    print("\n----- TABLES WITH MOST FOREIGN KEYS -----")
    most_referencing = sorted(referencing_tables.items(), key=lambda x: x[1], reverse=True)
    for table, count in most_referencing[:10]:  # Top 10
        print(f"{table}: {count} foreign keys")
    
    # Tables with multiple foreign keys to the same table (strong relationships)
    print("\n----- STRONG RELATIONSHIPS (MULTIPLE FKs TO SAME TABLE) -----")
    strong_relationships = []
    for source, targets in detailed_relationships.items():
        for target, count in targets.items():
            if count > 1:  # More than one FK to the same table
                strong_relationships.append((source, target, count))
    
    strong_relationships.sort(key=lambda x: x[2], reverse=True)
    for source, target, count in strong_relationships[:20]:  # Show top 20
        print(f"{source} -> {target}: {count} foreign keys")
    
    # Relationship distribution
    fk_counts = list(referencing_tables.values())
    if fk_counts:
        print("\n----- FOREIGN KEY DISTRIBUTION -----")
        fk_counter = Counter(fk_counts)
        for count, tables in sorted(fk_counter.items()):
            print(f"Tables with {count} foreign keys: {tables}")
    
    # Tables with no relationships
    isolated_tables = table_names - set(referenced_tables.keys()) - set(referencing_tables.keys())
    print(f"\nIsolated tables (no relationships): {len(isolated_tables)}")
    
    # Detect potential circular references
    print("\n----- POTENTIAL CIRCULAR REFERENCES -----")
    circular_refs = []
    for source_table, target_tables in relationships.items():
        for target_table in target_tables:
            if target_table in relationships and source_table in relationships[target_table]:
                circular_refs.append((source_table, target_table))
    
    if circular_refs:
        for source, target in circular_refs:
            print(f"{source} <--> {target}")
    else:
        print("No circular references detected")
    
    # Generate GraphViz DOT file for visualization
    generate_graphviz_dot(detailed_relationships, referenced_tables, 10)
    
    return {
        "total_tables": total_tables,
        "tables_with_primary_keys": tables_with_primary_keys,
        "tables_with_foreign_keys": tables_with_foreign_keys,
        "total_relationships": total_relationships,
        "most_referenced_tables": most_referenced[:10],
        "tables_with_most_foreign_keys": most_referencing[:10],
        "isolated_tables_count": len(isolated_tables)
    }

def generate_graphviz_dot(relationships, reference_counts, top_count=10):
    """Generate a GraphViz DOT file for key relationships visualization"""
    
    # Get top referenced tables
    top_tables = sorted(reference_counts.items(), key=lambda x: x[1], reverse=True)[:top_count]
    top_table_names = [t[0] for t in top_tables]
    
    with open("db_relationships.dot", "w") as f:
        f.write("digraph DatabaseRelationships {\n")
        f.write("  rankdir=LR;\n")  # Left to right layout
        f.write("  node [shape=box, style=filled, fillcolor=lightblue];\n")
        
        # Write node definitions with counts for top tables
        for table, count in top_tables:
            f.write(f'  "{table}" [label="{table}\\n({count} refs)", fillcolor="#AED6F1"];\n')
        
        # Write edges for relationships involving top tables
        for source, targets in relationships.items():
            # If source is a top table or targets a top table
            in_top = source in top_table_names
            has_top_target = any(target in top_table_names for target in targets)
            
            if in_top or has_top_target:
                for target, count in targets.items():
                    if source in top_table_names or target in top_table_names:
                        # Edge thickness based on relationship strength
                        width = 1 + (count * 0.5)
                        # Use penwidth to show relationship strength
                        f.write(f'  "{source}" -> "{target}" [penwidth={width}')
                        
                        # Add labels for multiple relationships
                        if count > 1:
                            f.write(f', label="{count}"')
                        
                        f.write("];\n")
        
        f.write("}\n")
    
    print("\nGraphViz DOT file generated: db_relationships.dot")
    print("To create a visualization, install Graphviz and run: dot -Tpng db_relationships.dot -o db_relationships.png")

if __name__ == "__main__":
    analyze_relationships("output.json") 
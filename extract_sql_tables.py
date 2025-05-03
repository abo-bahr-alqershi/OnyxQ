#!/usr/bin/env python3
import re
import sys
import argparse
from pathlib import Path


class SqlTableExtractor:
    def __init__(self, case_sensitive=False):
        self.case_sensitive = case_sensitive
        # Regex flags
        self.flags = 0 if case_sensitive else re.IGNORECASE
        
    def remove_comments(self, sql_content):
        """Remove SQL comments (both -- and /* */) from SQL content"""
        # Remove single line comments (-- ...)
        sql_without_single_comments = re.sub(r'--.*?$', '', sql_content, flags=re.MULTILINE)
        # Remove multi-line comments (/* ... */)
        sql_without_comments = re.sub(r'/\*[\s\S]*?\*/', '', sql_without_single_comments)
        return sql_without_comments
    
    def extract_tables(self, sql_content):
        """Extract table names from SQL content"""
        # Remove all comments first
        clean_sql = self.remove_comments(sql_content)
        
        # Match CREATE TABLE statements with various forms
        # Handles: 
        # - CREATE TABLE name
        # - CREATE TABLE IF NOT EXISTS name
        # - CREATE TABLE "name" or CREATE TABLE `name` or CREATE TABLE [name]
        # - CREATE TEMPORARY TABLE name
        pattern = r'CREATE\s+(?:TEMPORARY\s+)?TABLE\s+(?:IF\s+NOT\s+EXISTS\s+)?(?:["\'`\[]?([\w\.\-]+)["\'`\]]?|(\S+))'
        
        tables = []
        for match in re.finditer(pattern, clean_sql, self.flags):
            # Get the table name (either quoted or unquoted version)
            table_name = match.group(1) if match.group(1) else match.group(2)
            if table_name and table_name.lower() not in ('if', 'not', 'exists'):
                tables.append(table_name)
                
        return tables
    
    def extract_from_file(self, file_path, encoding=None):
        """Extract table names from an SQL file"""
        # Try different encodings if not specified
        encodings_to_try = [encoding] if encoding else ['utf-8', 'latin-1', 'cp1252', 'iso-8859-1']
        
        for enc in encodings_to_try:
            try:
                with open(file_path, 'r', encoding=enc) as f:
                    sql_content = f.read()
                return self.extract_tables(sql_content)
            except UnicodeDecodeError:
                if enc == encodings_to_try[-1]:  # If this was the last encoding to try
                    print(f"Error: Could not decode {file_path} with any of the attempted encodings.", file=sys.stderr)
                    return []
                continue  # Try the next encoding
            except Exception as e:
                print(f"Error reading or parsing file {file_path}: {e}", file=sys.stderr)
                return []


def main():
    parser = argparse.ArgumentParser(description='Extract table names from SQL scripts')
    parser.add_argument('sql_file', help='Path to the SQL file')
    parser.add_argument('--case-sensitive', action='store_true', 
                        help='Enable case-sensitive table name extraction')
    parser.add_argument('-o', '--output', help='Output file (default: stdout)')
    parser.add_argument('-e', '--encoding', 
                        help='Specify file encoding (default: tries utf-8, latin-1, cp1252, iso-8859-1)')
    args = parser.parse_args()
    
    extractor = SqlTableExtractor(case_sensitive=args.case_sensitive)
    tables = extractor.extract_from_file(args.sql_file, encoding=args.encoding)
    
    output = '\n'.join(tables)
    
    if args.output:
        with open(args.output, 'w', encoding='utf-8') as f:
            f.write(output)
        print(f"Extracted {len(tables)} table names to {args.output}")
    else:
        print(output)


if __name__ == "__main__":
    main() 
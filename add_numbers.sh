#!/bin/bash

# Read header lines
head -3 table_models_mapping.txt > temp_file.txt

# Process the rest of the file, adding line numbers to actual mappings
count=1
while IFS= read -r line; do
  if [[ $line == \#* || -z $line ]]; then
    # Add category headers without numbers
    echo "$line" >> temp_file.txt
  else
    # Add line number to actual mappings
    echo "$count. $line" >> temp_file.txt
    ((count++))
  fi
done < <(tail -n +4 table_models_mapping.txt)

# Replace original file
mv temp_file.txt table_models_mapping.txt 
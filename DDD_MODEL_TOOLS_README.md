# Domain-Driven Design Model Tools

This repository contains tools for maintaining and generating domain models according to DDD principles in the ERP Pro system.

## Overview

The tools provided help maintain consistency in model design by enforcing proper inheritance hierarchies:

1. `Entity<T>` - For supporting entities that don't form aggregate boundaries
2. `AggregateRoot<T>` - For main business entities that form transaction boundaries

## Tools Available

### 1. Model Classification File

The `model_classification.txt` file maps each model to its appropriate type (Entity or AggregateRoot).

Format:
```
ModelName|ClassificationType
```

Example:
```
Company|AggregateRoot
Branch|AggregateRoot
BranchDocument|Entity
```

### 2. Entity Type Updater Script

The `update_entity_types.py` script scans code files and updates the inheritance type based on the classification file.

Usage:
```bash
python3 update_entity_types.py <classification_file> <modules_directory> [--dry-run]
```

Example:
```bash
# Test run without making changes
python3 update_entity_types.py model_classification.txt ERP_Pro.Domain/Modules --dry-run

# Apply changes
python3 update_entity_types.py model_classification.txt ERP_Pro.Domain/Modules
```

### 3. Entity Model Generator Script

The `generate_entity_model.py` script generates new model files using the appropriate base class.

Usage:
```bash
python3 generate_entity_model.py <model_name> <module_name> [--properties prop1=type1 prop2=type2 ...] [--output-dir dir]
```

Example:
```bash
# Generate a Customer model in the SalesCustomers module
python3 generate_entity_model.py Customer SalesCustomers --properties CustomerName=string CustomerNumber=int CustomerType=string? Active=bool
```

The script generates:
1. An entity/aggregate root class file
2. A value object ID class file

## How to Use

### Adding a New Model

1. Determine whether your model should be an Entity or AggregateRoot
2. Add the model to `model_classification.txt`
3. Generate the model files using the generator script

### Updating Existing Models

1. Update the model's classification in `model_classification.txt` if needed
2. Run the updater script to apply changes to the codebase

## Classification Criteria

When deciding whether a model should be an Entity or AggregateRoot, consider:

### AggregateRoot
- Forms a transaction boundary
- Has a distinct lifecycle
- Contains rules that apply to the entire aggregate
- Can exist independently
- Examples: Company, Customer, SalesOrder, Account

### Entity
- Belongs to an aggregate
- Cannot exist independently
- Has no distinct lifecycle outside its aggregate
- Examples: LineItem, Address, CustomerContact

## Statistics

- Total AggregateRoot models: 140
- Total Entity models: 515 
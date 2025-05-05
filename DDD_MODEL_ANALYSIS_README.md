# DDD Model Analysis and Update Suite

This collection of files provides tools to analyze and update your ERP_Pro domain models according to Domain-Driven Design (DDD) principles, specifically distinguishing between `Entity<T>` and `AggregateRoot<T>` models.

## Files Included

1. **model_classification.txt** - Contains the classification of all models from table_models_mapping.txt, categorizing each as either `Entity` or `AggregateRoot`.

2. **update_entity_types.py** - Basic script to update entity definitions based on the classification.

3. **update_entity_types_enhanced.py** - Enhanced version that handles more complex cases and edge cases.

4. **generate_value_objects.py** - Creates missing ValueObject ID classes for models.

## Model Classification Logic

Models were classified according to these DDD principles:

- **AggregateRoot**: Main business entities that form transaction boundaries and can exist independently. Examples include `Company`, `Customer`, `SalesOrder`, etc.

- **Entity**: Objects with identity and lifecycle, but accessed through their aggregate roots. Examples include `CustomerAddress`, `SalesOrderDetail`, etc.

The classification was determined by analyzing:
- Table relationships (master-detail patterns)
- Business significance of the model
- Transactional boundaries

## How to Use the Scripts

### 1. Update Model Base Classes

Run the enhanced script to update your models to use the correct base class:

```bash
python update_entity_types_enhanced.py
```

This script:
- Creates a backup of all original files
- Updates the class definitions to use either `Entity<T>` or `AggregateRoot<T>`
- Adds necessary imports
- Produces a detailed log of changes

### 2. Generate Missing ValueObjects

Run the ValueObject generator script:

```bash
python generate_value_objects.py
```

This script:
- Creates ValueObject ID classes for all models
- Organizes them in the appropriate ValueObjects directories
- Uses consistent namespace conventions

## Safety Features

- All scripts create backups before making changes
- Detailed logs track all modifications
- Files are only modified if necessary

## Notes on Classification

Some models might need adjustment based on your specific business rules. Review the classification and make changes to `model_classification.txt` if needed before running the scripts. 
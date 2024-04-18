[![Build Status](https://dev.azure.com/fluxera/Foundation/_apis/build/status/GitHub/fluxera.Fluxera.Utilities?branchName=main&stageName=BuildAndTest)](https://dev.azure.com/fluxera/Foundation/_build/latest?definitionId=76&branchName=main)

# Fluxera.ComponentModel.Annotations

A collection of custom data annotations.

## Available Attributes

### Datastore related attributes

- **```[CompositeIndex]```** 
  - An attribute to provide the composite indices of an entity.
  - Targets classes.
  - Allows multiple.
- **```[DateOnly]```**
  - A marker attribute to signal potential data stores to only store the date.
  - Targets properties and fields.
  - Denys multiple.
- **```[DatePrecision]```**
  - An attribute to provide the date precision to potential data stores.
  - Targets properties and fields.
  - Denys multiple.
- **```[Ignore]```**
  - A marker attribute to signal potential data stores to ignore this value.
  - Targets properties and fields.
  - Denys multiple.
- **```[Index]```**
  - An attribute to provide an index of the entity.
  - Targets properties and fields.
  - Denys multiple.
- **```[Reference]```**
  - An attribute to signal potential data stores that this property should be stored as database reference.
  - Targets properties and fields.
  - Denys multiple.

## Validation attributes

- **```[Contains]```**
  - A validation that checks if the annotated property contains the given check value.
  - Targets properties and fields.
  - Denys multiple.
- **```[EndsWith]```**
  - A validation attribute that checks if the value end with the given value.
  - Targets properties and fields.
  - Denys multiple.
- **```[EnforceTrue]```**
  - A validation attribute that checks if the value is ```true```.
  - Targets properties and fields.
  - Denys multiple.
- **```[ListLength]```**
  - A validation attribute to check the length of a list.
  - Targets properties and fields.
  - Denys multiple.
- **```[ListMaxLength]```**
  - A validation attribute to check the maximum length of a list.
  - Targets properties and fields.
  - Denys multiple.
- **```[ListMinLength]```**
  - A validation attribute to check the minimum length of a list.
  - Targets properties and fields.
  - Denys multiple.
- **```[NotEmpty]```**
  - A validation attribute to check if an enumerable contains at least one element.
  - Targets properties and fields.
  - Denys multiple.
- **```[RequiredIf]```**
  - A validation attribute that checks if the value is required when a condition is met.
  - Targets properties and fields.
  - Denys multiple.
- **```[StartsWith]```**
  - A validation attribute that checks if the value starts with the given value.
  - Targets properties and fields.
  - Denys multiple.

## Datatype attributes

- **```[Currency]```**
  - A data-type attribute for currency values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[Date]```**
  - A data-type attribute for date values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[DateTime]```**
  - A data-type attribute for date-time values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[Duration]```**
  - A data-type attribute for duration (timespan) values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[ImageUrl]```**
  - A data-type attribute for image-url values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[MultilineText]```**
  - A data-type attribute for multiline text values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[Password]```**
  - A data-type attribute for password values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[PostalCode]```**
  - A data-type attribute for postal code values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[Select]```**
  - A data-type attribute to signal that the values comes from a selection of values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[Text]```**
  - A data-type attribute for text values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[Time]```**
  - A data-type attribute for time values.
  - Targets properties, fields and parameters.
  - Denys multiple.
- **```[Upload]```**
  - A data-type attribute for upload values.
  - Targets properties, fields and parameters.
  - Denys multiple.

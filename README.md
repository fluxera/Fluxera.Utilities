[![Build Status](https://dev.azure.com/fluxera/Foundation/_apis/build/status/GitHub/fluxera.Fluxera.Utilities?branchName=main&stageName=BuildAndTest)](https://dev.azure.com/fluxera/Foundation/_build/latest?definitionId=76&branchName=main)

# Utilities

A collection of common utilities and extension methods.

This is the place for all "common" helpers, extension methods and utilities. There is only one condition: The helpers may not require any third party packages.

## Available Helpers

- **```AsyncHelper```** Run async method in a synchonous context.
- **```RandomHelper```** Useful randomizing methods.
- **```TempPathHelper```** Create temp files or folders safely.
- **```Disposable```** Base class that implements ```IDisposable``` correctly.

## Available Collections

- **```SortedList```**  ```IList<T>``` implementation that inserts the items sorted using binary search.

## Available Extensions Methods

There are a lot of extensions methods available. here we sort them by the type they are implemented on.

### Array

- **```IsIndexWithin```** Checks if the given index is within the array.
- **```ToMemoryStream```** Creates a ```MemoryStream``` from a byte array.

### Assembly

- **```GetResourceAsStringAsync```** Gets the content of the given embedded resource location as string.

### Character

- **```Repeat```** Repeats the given ```char``` the specified number of times.

### Collection

- **```AddIfNotContains```** Adds item(s) to collection if they are not already in the collection.
- **```IsNullOrEmpty```** Checks if the collection is null or empty.
- **```RemoveMatching```** Removes all items from the collection that match a given predicate.

### String Conversions

The custom interfaces ```IConverter``` and ```ITryConverter``` provide a fluent interface for
converting strings to numeric, boolean and Guid values.

```c#
string value = "5";
int result = value.Convert().ToInt();

string value = "5";
bool success = value.TryConvert().ToInt(out int result);
```

```c#
char value = '5';
int result = value.Convert().ToInt();

char value = '5';
bool success = value.TryConvert().ToInt(out int result);
```

The ```Convert()``` extension methods also provide overloads to provide a custom ```IFormatProvider```. The default format provider is ```CultureInfo.CurrentCulture```.

### DateTime

- **```AddMonthsToEndOfMonth```** Adds the months to end of month.
- **```AddWeeks```** Adds an amount of weeks to a date value.
- **```CalculateAge```** Calculates the age based on a passed reference date.
- **```GetDayCountOfYear```** Get the number of days within that date year.
- **```GetDays```** Get the number of days between two dates.
- **```GetDaysOfMonthCount```** Returns the number of days in the month of a provided date.
- **```GetFirstDayOfMonth```** Returns the first day of the month of a provided date.
- **```GetFirstDayOfWeek```** Gets the first day of the week using a specific culture.
- **```GetLastDayOfMonth```** Returns the last day of the month of a provided date.
- **```GetLastDayOfWeek```** Gets the last day of the week using a specific culture.
- **```GetNextWeekday```** Gets the next occurrence of the specified weekday.
- **```GetPeriodOfDay```** Returns the period of the day ```PeriodOfDay.Morning```, ```PeriodOfDay.Afternoon```, ```PeriodOfDay.Evening```.
- **```GetPreviousWeekday```** Gets the previous occurrence of the specified weekday.
- **```GetWeekOfYear```** Gets the week number for a date time value based on the current culture settings.
- **```GetWeeksWeekday```** Gets the next occurrence of a specified weekday within the current week using a specific culture.
- **```IsDateEqual```** Determines if the date part of two ```DateTime``` values are equal.
- **```IsLeapYear```** Returns if or not a ```DateTime``` is during a leap year.
- **```IsTimeEqual```** Determines if the time part of two ```DateTime``` values are equal.
- **```IsToday```** Determines if a date is ```DateTime.Today```.
- **```IsWeekday```** Determines if a ```DateTime``` or ```DayOfWeek``` is a weekday.
- **```IsWeekend```**Determines if a ```DateTime``` or ```DayOfWeek``` is a weekend.
- **```Midnight```** Gets a ```DateTime```representing midnight on a specified date.
- **```NextMonth```** Gets the next month.
- **```Noon```** Gets a ```DateTime``` representing noon on a specified date.
- **```OrdinalSuffix```** Converts the day of a date to an ordinal string, f.e. 3 to '3rd'.
- **```SetTime```** Sets the time of the a ```DateTime``` with a specified precicion. All other parts are set to zero.
- **```ToUnixTimestamp```** Converts a ```DateTime``` to a UNIX timestamp (seconds since 01.01.1970).

### Dictionary

- **```ContainsValue```** Returns ```true``` if the value is contained in a dictionary.
- **```GetOrAdd```** Gets a value from a dictionary with given key. Returns a default value if the value cannot be found.
- **```GetOrDefault```** Gets a value from a dictionary. Returns ```default``` if the value cannot be found.
- **```TryGetValue```**  Tries to get a value from a dictionary.

### Enum

All operations utilize a cache of the enums metadata that is built lazily when using the extensions methods.

- **```EnumOptions```** Gets all options of an enum type.
- **```EnumValues```** Gets all values of an enum type.
- **```HasFlag```**  A generic version of ```Enum.HasFlag(enum)"```
- **```IsEmpty```** Gets a flag, indicating if the enum has no values.
- **```MaxValue```** Gets the maximum value of the enum.
- **```MinValue```** Gets the minimum value of the enum.

### Enumerable

- **```AsReadOnly```** Converts an enumerable to a read-only collection.
- **```ForEach```** Executes an ```Action``` for every item in the enumerable.
- **```IsAny```** Checks if a enumerable is not null or empty.
- **```IsNullOrEmpty```** Checks if the enumerable is null or empty.

### Guid

- **```IsEmpty```** Checks a ```Guid``` is ```Guid.Empty```.

### List

- **```AddFor```** Adds a value to a list if the value matches a predicate.
- **```AddRange```** Adds values to a list (```IList<T>```).
- **```AddRangeFor```** Adds values to a list if the value to add matches a predicate.
- **```AddRangeSorted```**  Adds values into a list sorted.
- **```AddSorted```** Adds a value into a list sorted.

### MemoryStream

- **```ToContentString```** Converts the content of the memory stream to a string.

### Nullable

- **```IsNull```** Checks if a nullable has no value.

### Numeric

The numeric extensions methods are available for the following primitives: ```byte```, ```short```, ```int```, ```long```

- **```IsBetween```** Determines if a value is between the specified values a and b (inclusive).
- **```IsEven```** Determines whether a value is even.
- **```IsOdd```** Determines whether a value is odd.
- **```Ordinalize```** Ordinalize a number, f.e. 6 to '6th'.
- **```Times```** Performs a specified action n times based on the value.

### Object

- **```GetDefaultValue```** Gets the type default value for a type. In case of reference types: ```null``` and for values types ```default(T)```.
- **```IsNull```** Returns ```true```, if the specified target reference is equal to the null reference.
- **```Locking```** Executes an ```Action``` by locking on a given object.

### Principal

- **```GetClaimValue```** Gets the first value of the given claim type and returns its value.
- **```GetClaimValues```** Gets all values of the given claim type and returns their values.
- **```GetDisplayName```** Gets the display name from the ```ClaimsIdentity``` or uses the subject.
- **```GetSubjectId```** Gets the subject identifier.
- **```IsAuthenticated```** Determines whether a principal is authenticated.

### Reflection

- **```DefinesAttribute```** Returns ```true``` if a ```MemberInfo``` instance is marked with the specified attribute.
- **```GetMemberType```**  Gets the underlying type of a ```MemberInfo``` instance.
- **```IsIndexer```** Determines if a ```PropertyInfo``` is an indexer.
- **```IsProperty```** Determines if a ```MethodInfo``` is a property.
- **```IsPropertyGetter```** Determines if a ```MethodInfo``` is a property getter.
- **```IsPropertySetter```** Determines if a ```MethodInfo``` is a property setter.

### Stream

- **```CopyTo```** Copies a ```Stream``` into a another one.
- **```CopyToMemory```** Copies a ```Stream``` into a local ```MemoryStream```.
- **```GetBytes```** Gets all bytes of a ```Stream```.
- **```GetReader```** Opens a ```StreamReader``` for a ```Stream```.
- **```GetWriter```** Opens a ```StreamWriter``` for a ```Stream```.
- **```Rewind```** Rewinds (set the current position to 0) a ```Stream```.
- **```Write```** Writes all bytes to the a ```Stream```.

### String

- **```ConcatWith```**  Concatenates a string with additional strings and an optional delimiter character.
- **```EnsureEndsWith```** Ensures that a string ends with a given suffix.
- **```EnsureStartsWith```** Ensures that a string starts with a given prefix.
- **```FormatInvariantWith```** Applies formatting to a string using the invariant culture.
- **```FormatWith```** Applies formatting to a string using the current culture.
- **```FromBase64```** Decodes a string from base64 to its normal representation.
- **```GetBytes```** Converts a string to a ```byte[]``` using a specific encoding.
- **```IsNullOrEmpty```** Determines if a string is ```null``` or ```string.Empty```.
- **```IsNullOrWhiteSpace```**Determines if a string is ```null``` or ```string.Empty``` or consists of whitespace-only characters.
- **```IsNumeric```** Checks if the contents of a string is a numeric value.
- **```Left```** Gets a substring of a string from beginning of the string.
- **```RemovePostFix```** Removes the first occurrence of postfixes from the end of a string.
- **```RemovePrefix```** Removes the first occurrence of prefixes from the beginning of a string.
- **```RemoveSpaces```** Removes all whitespace (not line endings, etc.) from a string.
- **```RemoveSpecialCharacters```** Removes all special characters from a string.
- **```Repeat```** Repeats a string value as provided by the repeat count.
- **```ReplaceDiacritics```** Replaces all diacritical marks with an ascii representation, fe. 'ü' to 'u'.
- **```ReplaceWithEmpty```** Replaces all occurrences of a string in an input string with ```string.Empty```.
- **```Reverse```**Reverses the a string.
- **```Right```** Gets a substring of a string from end of the string.
- **```Split```** Uses ```string.Split(string[], StringSplitOptions)``` method to split a string by a separator.
- **```ToBase64```** Encodes string to base64.
- **```ToEnum```** Converts a string to a matching enum value of a given enum type.
- **```ToMemoryStream```** Converts a string to a ```MemoryStream```.
- **```Truncate```**  Truncates a string to a specified length and optionally replaces the truncated part with '...' suffix.
- **```UrlSafeDecode```** Encodes a string for safe usage in URLs, f.e. for password reset or email confirmation tokens.
- **```UrlSafeEncode```** Decodes a given URL-safe string.

#### Inflection

- **```Pluralize```**  Returns the plural form of a word.
- **```Singularize```** Returns the singular form of a word.
- **```Titleize```** Return a string in a form that can be used as title.
- **```Humanize```** Humanizes a string.
- **```Pascalize```** Pascalizes a string.
- **```Camelize```** Camelizes a string.
- **```Underscore```** Replaces all dashes with underscores.
- **```Capitalize```** Capitalizes a string.
- **```Uncapitalize```** Uncapitalizes a string.
- **```Ordinalize```** Ordinalizes the given number that is given as string, f.e. '6' to '6th'.
- **```Dasherize```** Converts all underscores to dashes.

### Type

- **```CreateInstance```** Creates an instance of a type.
- **```DefinesAttribute```** Returns ```true```if the type is marked with a specified attribute.
- **```GetBaseClasses```** Gets all base classes recursively for a type.
- **```Implements```** Returns ```true``` if type implements a specified interface.
- **```IsAssignableTo```** Checks if a type is assignable to another type.
- **```IsCollection```** Determines if the a type is a collection.
- **```IsEnumerable```** Determines if the a type is an enumerable.
- **```IsNullable```** Determines if the a type is a nullable.
- **```IsNumeric```** Determines if the a type is numeric.
- **```IsPrimitive```** Determines whether a type is a primitive.
- **```UnwrapNullableType```** Gets the type without nullable if the type is a ```Nullable<T>```.

### Uri

- **```GetSubDomain```** Gets the sub-domain part from a ```Uri```.

### ValueType

- **```IsDefault```** Determines if a value is empty (```default(T)```).
- **```IsNullable```** Determines if a type is a nullable.
- **```ToNullable```** onverts a value to a corresponding nullable type.

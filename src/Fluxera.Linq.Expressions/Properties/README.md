[![Build Status](https://dev.azure.com/fluxera/Foundation/_apis/build/status/GitHub/fluxera.Fluxera.Utilities?branchName=main&stageName=BuildAndTest)](https://dev.azure.com/fluxera/Foundation/_build/latest?definitionId=76&branchName=main)

# Fluxera.Linq.Expressions

A collection of LINQ expression utilities and extension methods.

## Usage

The extenions methods use several utility classes that are publicly available through
this library to be used forother use-cases:

- **```Evaluator```** Enables the partial evaluation of queries.
- **```LocalCollectionExpander```** Expands local collection values.
- **```ParameterRebinder```**  Used for rebinding of parameters.

The utility classes are used to evaludate as much as possible to create a string representation of an ```Expression```.
The result of the extension can f.e. be used to create cache keys for expression-based data queries.

```c#
Expression<Func<Person, string>> expression = x => x.Name;
string? str = expression.ToExpressionString();
```

The other extension methods can be used to compose given expressions.

- **```And```** Creates an ```Expression``` that represents an bitwise AND operation.
- **```AndAlso```** Creates an ```Expression``` that represents a conditional AND operation that evaluates the second operand only if it has to.
- **```Or```** Creates an ```Expression``` that represents an bitwise OR operation.
- **```OrElse```** Creates an ```Expression``` that represents a conditional OR operation that evaluates the second operand only if it has to.

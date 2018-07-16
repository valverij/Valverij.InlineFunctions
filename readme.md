# Valverij.Inline

Designed to simplify single-line operations by allowing them to be chained with lambdas.

## Conditionals

Currently supports `Switch-Case` statements

### Switch-Case

```
// without a default
var result = Inline.Switch.On(2)
    .Returns<string>()
    .Case(0).Then("Not this one")
    .Case(1).Then("Or this one")
    .Case(2).Then("This one!")
    .Case(3).Then("Too far!");

// using with default
var result = Inline.Switch.On(2)
    .Returns<string>()
    .Case(0).Then("Not this one")
    .Case(1).Then("Or this one")
    .Case(3).Then("This one!")
    .Default(targetMessage);
```
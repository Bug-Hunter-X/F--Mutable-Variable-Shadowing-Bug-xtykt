# F# Mutable Variable Shadowing Bug

This example demonstrates a potential issue with mutable variables in F# when combined with local function scopes.

The `addOne` function takes a mutable variable as input and modifies it. However, because the local variable `x` in `addOne` shadows the outer variable `x`, the global variable is left unchanged after calling `addOne`.

The solution provided resolves the bug by eliminating the shadowing issue, ensuring the global variable is modified as expected.
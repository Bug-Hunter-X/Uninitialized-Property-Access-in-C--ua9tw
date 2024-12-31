# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a class property before it has been assigned a value.  This can lead to unexpected behavior or exceptions if not handled correctly.

## The Bug
The `bug.cs` file shows an example of a class with a property that might be accessed before it has been initialized.  Accessing `this.MyProperty` before a value is assigned can result in unexpected behavior. 

## The Solution
The `bugSolution.cs` file provides a corrected version.  This version addresses the issue by ensuring that the property is initialized with a default value before accessing it. This also includes demonstrating error handling.
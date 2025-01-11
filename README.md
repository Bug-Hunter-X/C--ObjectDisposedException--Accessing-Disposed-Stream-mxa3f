# C# ObjectDisposedException: Accessing a Disposed Stream

This repository demonstrates a common error in C# that leads to an `ObjectDisposedException`. The error occurs when attempting to access an object after it has been disposed of using a `using` statement.  This example involves a `FileStream`.

## Bug Description
The code in `bug.cs` opens a `FileStream` within a `using` block.  After the `using` block finishes (and the stream is automatically disposed), the code attempts to read from the stream again. This results in the `ObjectDisposedException`. 

## Solution
The `bugSolution.cs` file presents the corrected version.  The access to the stream is limited to within the `using` block, preventing the exception.

## How to reproduce the bug
1. Clone this repository.
2. Compile and run `bug.cs`.  You will observe the `ObjectDisposedException` being thrown.
3. Compile and run `bugSolution.cs`. This should execute successfully without errors.

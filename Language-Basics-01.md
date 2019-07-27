Problem statement
You are given the String equation containing an equation of the form "A*B=C", where A, B, and C are positive integers that don't have leading zeros. One digit in the equation is missing. Determine and return the correct digit. If the missing digit cannot be determined (i.e., there is no solution or there is more than one solution), return -1 instead.

Definition
Class: FixMultiplication
Method : FindDigit
Parameters : string
Returns : int
Method signature : int FindDigit(String equation)
(be sure your method is public)

Notes
A digit is correct if and only if it produces a valid equation in which A, B, C are positive integers with no leading zeros.
Constraints
equation will have the form "A*B=C".
Each of A, B, C will be a nonempty string of between 1 and 4 characters, inclusive.
Each character in each of A, B, C will be either a digit ('0'-'9') or a question mark ('?').
There will be exactly one question mark in equation.
The numbers represented by A, B, C will not have leading zeros.
Examples
#1

42*47=1?74

Returns: 9

We know that 42*47 = 1974, so the missing digit is 9.

#2 4?*47=1974

Returns: 2

The same equation, another missing digit.

#3

"42*?7=1974"

Returns: 4

And again the same equation.

#4

"42*?47=1974"

Returns: -1

This test case has no valid solution. The numbers cannot have leading zeros, so we cannot fill in a zero in front of 47.

#5

"2*12?=247"

Returns: -1

Two times something will never be 247, so this test case has no solution either.
# ConvertToRoman
Console application for converting arabic to roman numbers.

A simple console application that takes a string, checks for arabic numbers, if any exist, 
converts them into roman numbers and returns a new string and the number of replacements made.

### Installation

1. open in Visual Studio (project was made in VS 2017)
2. Build > Build Solution (F6)
3. Test > Run > All tests (to run test units)

### Known issues

Number with a comma behind it won't get converted (and the string continues).

Example:

_Input: abc 123, def 456_

_Output: abc 123, def C DL VI_

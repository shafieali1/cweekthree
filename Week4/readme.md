Chapter 3: Making Decisions in C#
This README covers the topics from Slide 1 through Slide 21 (Input Validation) in Starting Out with Visual C#, Sixth Edition.
Overview
In this section, we learn how a C# program makes decisions based on conditions, compares values, checks user input, and validates data before using it.
Topics Covered
Decision structures and the if statement
Relational operators
The if-else statement
Nested decision structures
The if-else-if statement
Logical operators
bool variables and flags
Comparing strings
TryParse methods
Input validation
1. Decision Structures and the if Statement
A decision structure allows a program to execute code only when a condition is true. The if statement is used to check a condition.
if (sales > 50000)
{
    bonus = 500;
}
In this example, bonus is set to 500 only when sales is greater than 50000.
2. Relational Operators
Relational operators compare two values.
Operator
Meaning
Example
>
Greater than
x > 10
<
Less than
x < 10
>=
Greater than or equal to
x >= 10
<=
Less than or equal to
x <= 10
==
Equal to
x == 10
!=
Not equal to
x != 10
Remember: = assigns a value, while == compares two values.
3. The if-else Statement
An if-else statement chooses between two code blocks: one when the condition is true and another when it is false.
int score = 45;

if (score >= 50)
{
    MessageBox.Show("Pass");
}
else
{
    MessageBox.Show("Fail");
}
Because the score is 45, the program displays Fail.
4. Nested Decision Structures
A nested decision is an if statement inside another if statement. It is useful when a program needs to check more than one condition in stages.
int score = 75;
bool attendance = true;

if (score >= 50)
{
    if (attendance)
    {
        MessageBox.Show("You passed");
    }
    else
    {
        MessageBox.Show("Attendance requirement not met");
    }
}
else
{
    MessageBox.Show("Score requirement not met");
}
The program first checks the score. If the score meets the requirement, it then checks attendance.
5. The if-else-if Statement
Use if-else-if when a program needs to check several conditions.
int score = 85;

if (score >= 90)
{
    MessageBox.Show("Grade A");
}
else if (score >= 80)
{
    MessageBox.Show("Grade B");
}
else if (score >= 70)
{
    MessageBox.Show("Grade C");
}
else
{
    MessageBox.Show("Grade D");
}
The program displays Grade B because 85 is below 90 but at least 80.
6. Logical Operators
Logical operators combine conditions or reverse a condition.
Operator
Meaning
Description
&&
AND
Both conditions must be true
`

`
!
NOT
Reverses a Boolean value
AND (&&)
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}
Both conditions must be true for the message to appear.
OR (||)
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("The temperature is in the danger zone.");
}
The message appears if either condition is true.
NOT (!)
if (!(temperature > 100))
{
    MessageBox.Show("The temperature is not above the maximum.");
}
The ! operator reverses the result of the condition.
7. bool Variables and Flags
A bool variable stores one of two values: true or false.
A flag is a variable used to indicate whether a particular condition exists.
bool isLoggedIn = true;

if (isLoggedIn)
{
    MessageBox.Show("The user is logged in.");
}
8. Comparing Strings
Strings store text, such as names. You can compare strings using ==, !=, or String.Compare.
string name1 = "Ali";
string name2 = "Ali";

if (name1 == name2)
{
    MessageBox.Show("The names are the same.");
}
You can also compare a string variable with a string literal:
if (name1 != "Bob")
{
    MessageBox.Show("The name is not Bob.");
}
With String.Compare, a result of 0 indicates that the strings compare as equal:
if (String.Compare(name1, name2) == 0)
{
    MessageBox.Show("The names are the same.");
}
9. Preventing Conversion Exceptions with TryParse
Users may enter text that cannot be converted to a number. The TryParse methods check whether a conversion succeeds and return true or false.
Common methods include:
int.TryParse() — for integers
double.TryParse() — for double-precision numbers
decimal.TryParse() — for decimal numbers
Example:
int age;

if (int.TryParse(textBox1.Text, out age))
{
    MessageBox.Show("The input is a valid integer.");
}
else
{
    MessageBox.Show("Please enter a whole number.");
}
The out keyword allows TryParse to place the converted value in the age variable when the conversion succeeds.
10. Input Validation
Input validation means checking data before using it to make sure it meets the program's requirements.
TryParse checks whether input can be converted to a number, but it does not determine whether the number is reasonable for the task.
For example, 999 is a valid integer, but it is not a reasonable number of working hours in one week. A program can validate that hours are greater than 0 and no more than 168.
int hours;

if (int.TryParse(textBox1.Text, out hours))
{
    if (hours > 0 && hours <= 168)
    {
        MessageBox.Show("The number of hours is valid.");
    }
    else
    {
        MessageBox.Show("Hours must be between 1 and 168.");
    }
}
else
{
    MessageBox.Show("Please enter a whole number.");
}
For test scores, a program could check that the score is between 0 and 100:
if (testScore >= 0 && testScore <= 100)
{
    MessageBox.Show("The test score is within range.");
}
Key Difference
TryParse: Checks whether the input can be converted to the required data type.
Input validation: Checks whether the converted value meets the program's rules and acceptable range.
Summary
By the end of Slide 21, you should understand how to:
Make decisions with if, if-else, nested if, and if-else-if.
Compare values using relational operators.
Combine conditions with &&, ||, and !.
Store true/false values with bool.
Compare strings.
Safely check numeric input with TryParse.
Validate that input is reasonable before using it.

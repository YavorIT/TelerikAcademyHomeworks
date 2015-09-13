
/*
                         Problem 7.* Arithmetical expressions

    Write a program that calculates the value of given arithmetical expression.
    The expression can contain the following elements only:

    1. Real numbers, e.g. 5, 18.33, 3.14159, 12.6
    2. Arithmetic operators: +, -, *, / (standard priorities)
    3. Mathematical functions: ln(x), sqrt(x), pow(x,y)
    4. Brackets (for changing the default priorities): (, )

                         Examples:

    input	                                                output
    (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)             |	~10.6
    pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)  |   ~21.22


    Hint: Use the classical Shunting-yard algorithm and Reverse Polish notation.
*/

using System;

class ArithmeticalExpressions
{
    static string Input()
    {
        Console.WriteLine("Enter your expression below:");
        return Console.ReadLine();
    }

    static void Main()
    {
        string input = Input();
        ShuntingYardAlgorithm.Implementate(input);
        string[] resultFromTheShuntingYard = ShuntingYardAlgorithm._outputString.Split(' ');
        ReversePolishNotation.Implementate(resultFromTheShuntingYard);

        Console.WriteLine("The result is: {0}", ReversePolishNotation._result);
    }
}
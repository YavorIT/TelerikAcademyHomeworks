
using System;
using System.Collections.Generic;

class ReversePolishNotation
{
    static Stack<double> _numbers = new Stack<double>();
    public static double _result;

    public static void Implementate (string[] input)
    {
        foreach (string token in input)
        {
            if(isValue(token))
            {
                _numbers.Push(double.Parse(token));
            }else
            {
                int numberOfArguments = NumberOfArgumentsNeededForTheOperation(token);
                if(_numbers.Count < numberOfArguments)
                {
                    Console.WriteLine("Not enough values in the expression!");
                    return;
                }
                else
                {
                  double resultOfEvaluation = EvaluateTheOperator(token);
                  _numbers.Push(resultOfEvaluation);
                }
            }
        }

        if(_numbers.Count == 1)
        {
            _result = _numbers.Pop();
        }
        else
        {
            Console.WriteLine("The input expression have too many values!");
            return;
        }
    }

    private static double EvaluateTheOperator(string input)
    {
        switch (input)
        {
            case "sqrt":
                return Math.Sqrt(_numbers.Pop());

            case "ln":
                return Math.Log(_numbers.Pop());

            case "pow":
                double power = _numbers.Pop();
                double number = _numbers.Pop();
               return Math.Pow(number, power);

            case "*":
                return _numbers.Pop() * _numbers.Pop();

            case "/":
                double divideBy = _numbers.Pop();
                double toDivide = _numbers.Pop();
                return toDivide / divideBy;

            case "+":
                return _numbers.Pop() + _numbers.Pop();

            case "-":
                double subtractWith = _numbers.Pop();
                double toSubtract = _numbers.Pop();
                return toSubtract - subtractWith;

            default:
                return 0;
        }
    }

    private static int NumberOfArgumentsNeededForTheOperation(string thisToken)
    {
       switch(thisToken)
        {
            case "sqrt":
            case "ln":
                return 1;
            default:
                return 2;
        }
    }

    static bool isValue (string thisToken)
    {
        return thisToken != string.Empty ? (int)thisToken[thisToken.Length - 1] >= 48 && (int)thisToken[thisToken.Length - 1] <= 57 : false;
    }
}


using System;
using System.Collections.Generic;

class ShuntingYardAlgorithm
{
     static Stack<string> _operatorsAndFunctions = new Stack<string>();
     public static string _outputString = string.Empty;
     static string _space = " ";

    public static void Implementate(string input)
    {
        string result = string.Empty;
        bool flag = false;
        bool isPositiveNumber;
        bool isNegativeNumber = false;

        for (int i = 0; i < input.Length; i++)
        {
            isPositiveNumber = (int)input[i] >= 48 && (int)input[i] <= 57 || input[i] == '.';

            if (i < input.Length - 1)
            {
                isNegativeNumber = input[i] == '-' && (int)input[i + 1] >= 48 && (int)input[i + 1] <= 57 || input[i] == '.';
            }

            if (isPositiveNumber || isNegativeNumber)
            {
                result += input[i];
                flag = true;
            }
            if (flag == true && !isPositiveNumber && !isNegativeNumber)
            {
                _outputString += result + _space;
                flag = false;
                result = string.Empty;
            }

            FunctionPush(input, i);

            if (IsComma(input[i].ToString()))
            {
                while (!IsLeftParenthesis(_operatorsAndFunctions.Peek()) && _operatorsAndFunctions.Count > 0)
                {
                    _outputString += _operatorsAndFunctions.Pop() + _space;
                }
            }

            if (IsOperator(input[i].ToString()) && !isNegativeNumber)
            {
                while (_operatorsAndFunctions.Count > 0 && IsOperator(_operatorsAndFunctions.Peek()))
                {
                    if (!isRightAssociative(input[i].ToString()) && _operatorsAndFunctions.Count > 0 && (Priority(input[i].ToString()) <= Priority(_operatorsAndFunctions.Peek())) || (isRightAssociative(input[i].ToString()) && Priority(input[i].ToString()) < Priority(_operatorsAndFunctions.Peek())))
                    {
                        _outputString += _operatorsAndFunctions.Pop() + _space;
                    }
                    else
                    {
                        break;
                    }
                }
                _operatorsAndFunctions.Push(input[i].ToString());
            }

            if (IsLeftParenthesis(input[i].ToString()))
            {
                _operatorsAndFunctions.Push(input[i].ToString());
            }

            if (IsRightParenthesis(input[i].ToString()))
            {
                while (_operatorsAndFunctions.Count > 0 && !IsLeftParenthesis(_operatorsAndFunctions.Peek()))
                {
                    _outputString += _operatorsAndFunctions.Pop() + _space;
                }
                _operatorsAndFunctions.Pop();
            }
        }

        while (_operatorsAndFunctions.Count > 0)
        {
            if (IsLeftParenthesis(_operatorsAndFunctions.Peek()) || IsRightParenthesis(_operatorsAndFunctions.Peek()))
            {
                Console.WriteLine("There are mismatched parentheses!");
                return;
            }
            _outputString += _operatorsAndFunctions.Pop() + _space;
        }
        _outputString = _outputString.TrimEnd(' ');
    }

    private static bool isRightAssociative(string thisOperator)
    {
        switch (thisOperator)
        {
            case "p":
                return true;
            default:
                return false;
        }
    }

    static bool IsOperator(string input)
    {
        return input == "*" || input == "/" || input == "+" || input == "-" || input == "sqrt" || input == "pow" || input == "ln";
    }

    static bool IsComma(string input)
    {
        return input.Equals(",");
    }

    static bool IsLeftParenthesis(string input)
    {
        return input.Equals("(");
    }

    static bool IsRightParenthesis(string input)
    {
        return input.Equals(")");
    }

    static void FunctionPush(string input, int currentCharacter)
    {
        bool isSqrt = false;
        bool isPow = false;
        bool isLn = false;

        if (currentCharacter < input.Length - 4)
        {
            isSqrt = IsSquareRoot(input.Substring(currentCharacter, 4));
            isPow = IsPower(input.Substring(currentCharacter, 3));
            isLn = isLogarithm(input.Substring(currentCharacter, 2));
        }

        if (isSqrt)
        {
            _operatorsAndFunctions.Push(input.Substring(currentCharacter, 4));
        }
        else if (isPow)
        {
            _operatorsAndFunctions.Push(input.Substring(currentCharacter, 3));
        }
        else if (isLn)
        {
            _operatorsAndFunctions.Push(input.Substring(currentCharacter, 2));
        }
    }

    static bool IsSquareRoot(string isSqrt)
    {
        return isSqrt.Equals("sqrt");
    }

    static bool IsPower(string isPower)
    {
        return isPower.Equals("pow");
    }

    static bool isLogarithm(string isLn)
    {
        return isLn.Equals("ln");
    }

    static int Priority(string operatorSymbol)
    {
        switch (operatorSymbol)
        {
            case "pow":
            case "sqrt":
            case "ln":
                return 4;
            case "*":
            case "/":
                return 3;
            case "+":
            case "-":
                return 2;
            case "(":
            case ")":
                return -1;
        }
        return 1;
    }
}
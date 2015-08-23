﻿
/*
                     Problem 1. Say Hello

    Write a method that asks the user for his name and prints “Hello, <name>”
    Write a program to test this method.
*/

using System;

class SayHello
{
    static string YourName ()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static void Main()
    {
        Console.WriteLine("Hello, {0}!", YourName());
    }
}
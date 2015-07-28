
/*
                Problem 12.** Falling Rocks

    Implement the "Falling Rocks" game in the text console.
    A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
    A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
    Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density.
    The dwarf is (O).
    Ensure a constant game speed by Thread.Sleep(150).
    Implement collision detection and scoring system. 
*/

using System;
using System.Threading;
using System.Collections.Generic;

class FallingRocksGame
{
    public static void GameOver(int points, int startTime)
    {
        int rankTime = 60;
        string rank = "Nice";
        if (((Environment.TickCount - startTime) / 1000) >= rankTime)
            rank = "Good";

        if (((Environment.TickCount - startTime) / 1000) >= rankTime * 2)
            rank = "Awesome";

        if (((Environment.TickCount - startTime) / 1000) >= rankTime * 3)
            rank = "Master";

        if (((Environment.TickCount - startTime) / 1000) >= rankTime * 4)
            rank = "NO WAY";

        Console.Clear();

        Console.SetCursorPosition((Console.WindowWidth / 2) - 4, 0);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Game Over!");

        Console.SetCursorPosition((Console.WindowWidth / 2) - 4, 1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Your Rank: {0}", rank);

        Console.SetCursorPosition((Console.WindowWidth / 2) - 4, 2);
        Console.WriteLine("Points: {0}", points);

        Thread.Sleep(5000);
        return;
    }

    struct Position
    {

        public int row;
        public int col;

        public Position(int col, int row)
        {
            this.col = col;
            this.row = row;
        }
    }

    static void Main()
    {
        byte right = 0;
        byte left = 1;
        int direction = right;
        int waitTime = 50000;
        int maxDensity = 20;
        int density = 20;
        int minDensity = 19;
        int startTime = Environment.TickCount;
        //  int sleepTime = 150;
        int points = 0;

        Position[] directions = new Position[]
        {
            new Position (1, 0), // right
            new Position(-1, 0), // left
        };

        int[] rock = new int[12]
        {
            33, // ! Red
            64, // @ Red
            42, // * Red
            38, // & Blue
            43, // + Blue
            37, // % Blue
            36, // $ Yellow
            35, // # Yellow
            94, // ^ Yellow
            46, // . Green
            59, // ; Green
            45, // - Green
        };

        List<Position> rocks = new List<Position>();
        List<char> symbols = new List<char>();
        List<int> colors = new List<int>();

        Random randomRocksGenerator = new Random();
        Random randomPlaceAndCount = new Random();

        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;

        Position nextDirection;

        Console.CursorVisible = false;

        Console.SetCursorPosition(Console.WindowWidth / 2 - 30, 0);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("You are the white dwarf at the bottom!");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 30, 1);
        Console.WriteLine("Try to avoid the falling rocks!");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 30, 2);
        Console.WriteLine("You can move the dwarf left or right with the arrow keys!");

        Thread.Sleep(10000);

        Console.Clear();

        Position dwarf = new Position(Console.WindowWidth / 2, Console.WindowHeight - 1);
        Console.SetCursorPosition(dwarf.col, dwarf.row);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("(0)");

        while (true)
        {
            density = randomPlaceAndCount.Next(minDensity, maxDensity);

            for (int i = 0; i < maxDensity - density; i++)
            {
                int rockSelection;
                Position rockPlace = new Position(randomPlaceAndCount.Next(0, Console.WindowWidth - 1), 0);
                rocks.Insert(rocks.Count, rockPlace);
                rockSelection = randomRocksGenerator.Next(0, 11);
                colors.Insert(colors.Count, rockSelection);

                symbols.Insert(symbols.Count, (char)rock[rockSelection]);

                if (rockSelection >= 0 && rockSelection < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (rockSelection >= 3 && rockSelection < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (rockSelection >= 6 && rockSelection < 9)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (rockSelection >= 9 && rockSelection < 11)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.SetCursorPosition(rockPlace.col, rockPlace.row);
                Console.Write((char)rock[rockSelection]);
            }
            for (int i = 0; i < waitTime; i++)
            {
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow && dwarf.col > 0)
                    {
                        direction = left;
                        Console.SetCursorPosition(dwarf.col, dwarf.row);
                        Console.Write("   ");
                        nextDirection = directions[direction];
                        dwarf = new Position(dwarf.col + nextDirection.col, dwarf.row + nextDirection.row);
                        Console.SetCursorPosition(dwarf.col, dwarf.row);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("(0)");
                        Console.SetCursorPosition(0, 0);
                    }
                    if (userInput.Key == ConsoleKey.RightArrow && dwarf.col < Console.WindowWidth - 4)
                    {
                        direction = right;
                        Console.SetCursorPosition(dwarf.col, dwarf.row);
                        Console.Write("   ");
                        nextDirection = directions[direction];
                        dwarf = new Position(dwarf.col + nextDirection.col, dwarf.row + nextDirection.row);
                        Console.SetCursorPosition(dwarf.col, dwarf.row);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("(0)");
                        Console.SetCursorPosition(0, 0);
                    }
                }
            }
            for (int i = 0; i < rocks.Count; i++)
            {
                Position thisRock = rocks[i];
                Console.SetCursorPosition(thisRock.col, thisRock.row);
                Console.Write(" ");
                thisRock.row++;

                if (thisRock.row < Console.WindowHeight)
                {
                    Console.SetCursorPosition(thisRock.col, thisRock.row);
                    if (colors[i] >= 0 && colors[i] < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (colors[i] >= 3 && colors[i] < 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    if (colors[i] >= 6 && colors[i] < 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    if (colors[i] >= 9 && colors[i] < 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.Write(symbols[i]);
                    rocks[i] = thisRock;
                }
                else
                {
                    rocks.Remove(rocks[i]);
                    symbols.Remove(symbols[i]);
                    colors.Remove(colors[i]);
                }
            }
            foreach (Position obstacle in rocks)
            {
                if (obstacle.row == dwarf.row && (obstacle.col == dwarf.col || obstacle.col == (dwarf.col + 1) || obstacle.col == (dwarf.col + 2)))
                {
                    GameOver(points, startTime);
                    return;
                }
            }

            if (((Environment.TickCount - startTime) / 1000) % 10 == 0)
            {
                points += 37;

                if (((Environment.TickCount - startTime) / 1000) % 30 == 0)
                {
                    points *= 2;
                    maxDensity--;
                }

                waitTime -= 1000;
                minDensity--;
            }
            //   Thread.Sleep(sleepTime);  I'm not using the Thread.Sleep method because this will cause my dwarf move at the same 
            //                             time as the rocks are falling.
            //                             That's why i use the "for" cycle to take some time between the falling so that i can move my dwarf faster.
            //                             If you want you can change the settings and make the program use Thread.Sleep!
        }
    }
}
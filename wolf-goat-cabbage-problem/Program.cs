// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Once upon a time a farmer went to a market and purchased a wolf, a goat, and a cabbage.\n" +
        "On his way home, the farmer came to the bank of a river and rented a boat.\n" +
        "But crossing the river by boat, the farmer could carry only himself and a single one of his purchases: the wolf, the goat, or the cabbage.\n" +
        "If left unattended together, the wolf would eat the goat, or the goat would eat the cabbage.\n " +
        "The farmer's challenge was to carry himself and his purchases to the far bank of the river, leaving each purchase intact.");

        List<string> rightSide = new List<string> { "wolf", "goat", "cabbage", "farmer" };
        List<string> leftSide = new List<string>();

        bool gameOver = false;

        string moveWolf = "Take the wolf to the other side.";
        string moveGoat = "Take the goat to the other side.";
        string moveCabbage = "Take the cabbage to the other side.";
        string leaveAlone = "Have the farmer cross to the other side alone.";

        static void WhatNext()
        {
            Console.WriteLine();
            Console.WriteLine("What should the farmer do next?");
        }

        static void WolfEats()
        {
            Console.WriteLine("The wolf ate the goat.");
            Console.WriteLine("Game Over. Close the console and try again from the beginning.");
        }

        static void GoatEats()
        {
            Console.WriteLine("The goat ate the cabbage.");
            Console.WriteLine("Game Over. Close the console and try again from the beginning.");
        }

        static void EveryoneEats()
        {
            Console.WriteLine("The farmer left everything on one side. The goat ate the cabbage and then the wolf ate the goat.");
            Console.WriteLine("Game Over. Close the console and try again from the beginning.");
        }

        static void EnterLetter()
        {
            Console.WriteLine("Please make sure you input one of the above letters.");
            Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("In what order must he bring each of his purchases across the river?");
        Console.WriteLine("Type the letter that corresponds with your choice, then press enter.");

        Console.WriteLine();

        while (gameOver == false)
        {
            if (rightSide.Contains("wolf") && rightSide.Contains("goat") && rightSide.Contains("cabbage") && rightSide.Contains("farmer"))
            {
                Console.WriteLine("a. " + moveWolf);
                Console.WriteLine("b. " + moveGoat);
                Console.WriteLine("c. " + moveCabbage);
                Console.WriteLine("d. " + leaveAlone);

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    GoatEats();
                    gameOver = true;
                }

                else if (choice == "b")
                {
                    rightSide.Remove("goat");
                    rightSide.Remove("farmer");
                    leftSide.AddRange(new string[] { "goat", "farmer" });
                    Console.WriteLine("\nThe farmer is on the left side with the goat.");
                    WhatNext();
                }

                else if (choice == "c")
                {
                    WolfEats();
                    gameOver = true;
                }

                else if (choice == "d")
                {
                    EveryoneEats();
                    gameOver = true;
                }

                else
                {
                    EnterLetter();
                }

            }

            if (leftSide.Contains("goat") && leftSide.Contains("farmer") && !leftSide.Contains("wolf") && !leftSide.Contains("cabbage"))
            {
                Console.WriteLine("a. " + moveGoat);
                Console.WriteLine("b. " + leaveAlone);

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    leftSide.Remove("goat");
                    leftSide.Remove("farmer");
                    rightSide.AddRange(new string[] { "goat", "farmer" });
                    Console.WriteLine("\nThe farmer is on the right side with the wolf, goat, and cabbage.");
                    WhatNext();
                }

                else if (choice == "b")
                {
                    leftSide.Remove("farmer");
                    rightSide.Add("farmer");
                    Console.WriteLine("\nThe farmer is on the right side with the wolf and cabbage.");
                    WhatNext();
                }

                else
                {
                    EnterLetter();
                }
            }

            if (rightSide.Contains("wolf") && rightSide.Contains("cabbage") && rightSide.Contains("farmer") && !rightSide.Contains("goat"))
            {
                Console.WriteLine("a. " + moveWolf);
                Console.WriteLine("b. " + moveCabbage);
                Console.WriteLine("c. " + leaveAlone);

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    rightSide.Remove("wolf");
                    rightSide.Remove("farmer");
                    leftSide.AddRange(new string[] { "wolf", "farmer" });
                    Console.WriteLine("\nThe farmer is on the left side with the goat and wolf.");
                    WhatNext();
                }

                else if (choice == "b")
                {
                    rightSide.Remove("cabbage");
                    rightSide.Remove("farmer");
                    leftSide.AddRange(new string[] { "cabbage", "farmer" });
                    Console.WriteLine("\nThe farmer is on the left side with the goat and cabbage.");
                    WhatNext();
                }

                else if (choice == "c")
                {
                    rightSide.Remove("farmer");
                    leftSide.Add("farmer");
                    Console.WriteLine("\nThe farmer is on the left side with the goat.");
                    WhatNext();
                }

                else
                {
                    EnterLetter();
                }
            }

            if (leftSide.Contains("goat") && leftSide.Contains("wolf") && leftSide.Contains("farmer") && !leftSide.Contains("cabbage"))
            {
                Console.WriteLine("a. " + moveGoat);
                Console.WriteLine("b. " + moveWolf);
                Console.WriteLine("c. " + leaveAlone);

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    leftSide.Remove("goat");
                    leftSide.Remove("farmer");
                    rightSide.AddRange(new string[] { "goat", "farmer" });
                    Console.WriteLine("\nThe farmer is on the right side with the goat and cabbage.");
                    WhatNext();
                }

                else if (choice == "b")
                {
                    leftSide.Remove("wolf");
                    leftSide.Remove("farmer");
                    rightSide.AddRange(new string[] { "wolf", "farmer" });
                    Console.WriteLine("\nThe farmer is on the right side with the wolf and cabbage.");
                    WhatNext();
                }

                else if (choice == "c")
                {
                    WolfEats();
                    gameOver = true;
                }

                else
                {
                    EnterLetter();
                }

            }

            if (leftSide.Contains("goat") && leftSide.Contains("cabbage") && leftSide.Contains("farmer") && !leftSide.Contains("wolf"))
            {
                Console.WriteLine("a. " + moveGoat);
                Console.WriteLine("b. " + moveCabbage);
                Console.WriteLine("c. " + leaveAlone);

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    leftSide.Remove("goat");
                    leftSide.Remove("farmer");
                    rightSide.AddRange(new string[] { "goat", "farmer" });
                    Console.WriteLine("\nThe farmer is on the right side with the goat and wolf.");
                    WhatNext();
                }

                else if (choice == "b")
                {
                    leftSide.Remove("cabbage");
                    leftSide.Remove("farmer");
                    rightSide.AddRange(new string[] { "cabbage", "farmer" });
                    Console.WriteLine("\nThe farmer is on the right side with the wolf and cabbage.");
                    WhatNext();
                }

                else if (choice == "c")
                {
                    GoatEats();
                    gameOver = true;
                }

                else
                {
                    EnterLetter();
                }
            }

            if (rightSide.Contains("goat") && rightSide.Contains("cabbage") && rightSide.Contains("farmer") && !rightSide.Contains("wolf"))
            {
                Console.WriteLine("a. " + moveGoat);
                Console.WriteLine("b. " + moveCabbage);
                Console.WriteLine("c. " + leaveAlone);

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    rightSide.Remove("goat");
                    rightSide.Remove("farmer");
                    leftSide.AddRange(new string[] { "goat", "farmer" });
                    Console.WriteLine("\nThe farmer is on the left side with the goat and wolf.");
                    WhatNext();
                }

                else if (choice == "b")
                {
                    rightSide.Remove("cabbage");
                    rightSide.Remove("farmer");
                    leftSide.AddRange(new string[] { "cabbage", "farmer" });
                    Console.WriteLine("\nThe farmer is on the left side with the wolf and cabbage.");
                    WhatNext();
                }

                else if (choice == "c")
                {
                    GoatEats();
                    gameOver = true;
                }

                else
                {
                    EnterLetter();
                }
            }

            if (rightSide.Contains("goat") && rightSide.Contains("wolf") && rightSide.Contains("farmer") && !rightSide.Contains("cabbage"))
            {
                Console.WriteLine("a. " + moveGoat);
                Console.WriteLine("b. " + moveWolf);
                Console.WriteLine("c. " + leaveAlone);

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    rightSide.Remove("goat");
                    rightSide.Remove("farmer");
                    leftSide.AddRange(new string[] { "goat", "farmer" });
                    Console.WriteLine("\nThe farmer is on the left side with the goat and cabbage.");
                    WhatNext();
                }

                else if (choice == "b")
                {
                    rightSide.Remove("wolf");
                    rightSide.Remove("farmer");
                    leftSide.AddRange(new string[] { "wolf", "farmer" });
                    Console.WriteLine("\nThe farmer is on the left side with the wolf and cabbage.");
                    WhatNext();
                }

                else if (choice == "c")
                {
                    WolfEats();
                    gameOver = true;
                }

                else
                {
                    EnterLetter();
                }
            }

            if (leftSide.Contains("wolf") && leftSide.Contains("cabbage") && leftSide.Contains("farmer") && !leftSide.Contains("goat"))
            {
                Console.WriteLine("a. " + moveWolf);
                Console.WriteLine("b. " + moveCabbage);
                Console.WriteLine("c. " + leaveAlone);

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    leftSide.Remove("wolf");
                    leftSide.Remove("farmer");
                    rightSide.AddRange(new string[] { "wolf", "farmer" });
                    Console.WriteLine("\nThe farmer is on the right side with the wolf and goat.");
                    WhatNext();
                }

                else if (choice == "b")
                {
                    leftSide.Remove("cabbage");
                    leftSide.Remove("farmer");
                    rightSide.AddRange(new string[] { "cabbage", "farmer" });
                    Console.WriteLine("\nThe farmer is on the right side with the cabbage and goat.");
                    WhatNext();
                }

                else if (choice == "c")
                {
                    leftSide.Remove("farmer");
                    rightSide.Add("farmer");
                    Console.WriteLine("\nThe farmer is on the right side with the goat.");
                    WhatNext();
                }

                else
                {
                    EnterLetter();
                }
            }

            if (rightSide.Contains("goat") && rightSide.Contains("farmer") && !rightSide.Contains("wolf") && !rightSide.Contains("cabbage"))
            {
                Console.WriteLine("a. " + moveGoat);
                Console.WriteLine("b. " + leaveAlone);

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    rightSide.Remove("goat");
                    rightSide.Remove("farmer");
                    leftSide.AddRange(new string[] { "goat", "farmer" });
                    Console.WriteLine("\nThe farmer is on the left side with the wolf, goat, and cabbage.");
                    Console.WriteLine("The farmer made it across the river with all of his purchases. Congratulations! You did it!");
                    gameOver = true;
                }

                else if (choice == "b")
                {
                    rightSide.Remove("farmer");
                    leftSide.Add("farmer");
                    Console.WriteLine("\nThe farmer is on the left side with the wolf and cabbage.");
                    WhatNext();
                }

                else
                {
                    EnterLetter();
                }
            }
        }
    }
}






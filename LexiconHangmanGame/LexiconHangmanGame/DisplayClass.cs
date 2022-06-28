﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconHangmanGame
{
    internal class DisplayClass
    {

        public static void GreetingDisplay()
        {
            Console.WriteLine(
                "|----------------------------------------------------------|\n" +
                "| Welcome to the hangman game!                             |\n" +
                "|----------------------------------------------------------|\n" +
                "| Game rules                                               |\n" +
                "|----------------------------------------------------------|\n" +
                " - The game will pick a random word                       \n" +
                "   you as the player will have to geuss what word it is   \n" +
                "\n" +
                " - You will get a total of 10 geusses                     \n" +
                "   if you however geuss a letter that you already geussed that geuss will not count towards the 10 geusses\n" +
                "\n" +
                " - You could either geuss a letter and get a confirmation weither its correct or not\n" +
                "   or geuss on the whole word directly, if correct you win \n" +
                "   if wrong 1 geuss is used and you will not get a confirmation wither any of the letters was correct\n");
            LetTheGameBegin();

        }

        public static void LetTheGameBegin()
        {
            Console.WriteLine(
                "|----------------------------------------------------------|\n" +
                "| The game will now begin!                                 |\n" +
                "|----------------------------------------------------------|\n");
        }

        public static void SingelCharracterInput()
        {
            Console.WriteLine();
        }

        public static void FullWordInput()
        {
            Console.WriteLine();
        }

        public static void HangManIllustration(int wrongAnswer)
        {

            switch (wrongAnswer)
            {
                case 1:
                    {
                        Console.WriteLine("\n" +
                                          "+-------+");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("       ===");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("\n" +
                                          "+-------+");
                        Console.WriteLine("    |   |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("       ===");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("\n" +
                                          "+-------+");
                        Console.WriteLine("    |   |");
                        Console.WriteLine("    O   |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("       ===");
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("\n" +
                                          "+-------+");
                        Console.WriteLine("    |   |");
                        Console.WriteLine("    O   |");
                        Console.WriteLine("    |   |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("       ===");
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("\n" +
                                          "+-------+");
                        Console.WriteLine("    |   |");
                        Console.WriteLine("    O   |");
                        Console.WriteLine("   /|   |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("       ===");
                        break;
                    }

                case 6:
                    {
                        Console.WriteLine("\n" +
                                          "+-------+");
                        Console.WriteLine("    |   |");
                        Console.WriteLine("    O   |");
                        Console.WriteLine("   /|\\  |");
                        Console.WriteLine("        |");
                        Console.WriteLine("        |");
                        Console.WriteLine("       ===");
                        break;
                    }

                case 7:
                    {
                        Console.WriteLine("\n" +
                                          "+-------+");
                        Console.WriteLine("    |   |");
                        Console.WriteLine("    O   |");
                        Console.WriteLine("   /|\\  |");
                        Console.WriteLine("   /    |");
                        Console.WriteLine("        |");
                        Console.WriteLine("       ===");
                        break;
                    }

                case 8:
                    {
                        Console.WriteLine("\n" +
                                          "+-------+");
                        Console.WriteLine("    |   |");
                        Console.WriteLine("    O   |");
                        Console.WriteLine("   /|\\  |");
                        Console.WriteLine("   / \\  |");
                        Console.WriteLine("        |");
                        Console.WriteLine("       ===");
                        break;
                    }

                case 9:
                    {
                        Console.WriteLine("\n" +
                                          "+--------+");
                        Console.WriteLine("[R] |    |");
                        Console.WriteLine("    O    |");
                        Console.WriteLine("   /|\\   |");
                        Console.WriteLine("   / \\   |");
                        Console.WriteLine("         |");
                        Console.WriteLine("        ===");
                        break;
                    }

                case 10:
                    {
                        Console.WriteLine("\n" +
                                          "+--------+");
                        Console.WriteLine("[R] | [P]|");
                        Console.WriteLine("    O    |");
                        Console.WriteLine("   /|\\   |");
                        Console.WriteLine("   / \\   |");
                        Console.WriteLine("         |");
                        Console.WriteLine("        ===");
                        break;
                    }


            }
        }

    }
}
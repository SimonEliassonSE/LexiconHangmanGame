using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconHangmanGame
{
    internal class InputCollectingClass
    {

        public static string GetUserGeuss()
        {
            bool isNullOrWhite;
            string userInput;

            do
            {
                isNullOrWhite = true;
                Console.WriteLine("Please enter your geuss, may be a whole word or a singel char\n");
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    isNullOrWhite = true;
                    Console.WriteLine("Your input can not contain blankspace or null");
                }

                else if (!string.IsNullOrEmpty(userInput))
                {
                    isNullOrWhite = false;
                }


            } while (isNullOrWhite);

            return userInput;
        }

        public static string GoAgain()
        {
            bool invalid;
            string userResponse;
           
            do
            {
                invalid = false;
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("| Go again [y] stop [n] |");
                Console.WriteLine("|-----------------------|");
                userResponse = Console.ReadLine();
                if (string.IsNullOrEmpty(userResponse))
                {
                    invalid = false;
                    Console.WriteLine("Your input can not contain blankspace or null");
                }

                else if (userResponse == "y" || userResponse == "n")
                {
                    invalid = true;

                }

            } while(!invalid);

            return userResponse;         
        }

    }
}

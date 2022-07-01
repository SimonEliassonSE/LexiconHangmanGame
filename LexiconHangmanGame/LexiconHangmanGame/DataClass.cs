using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconHangmanGame
{
    // Gör en stringbuild som samlar alla fel svar
        // Gör en metod som förhindrar att antalet gissningar ökar om ordet är fel men har gissats tidigare!
    internal class DataClass
    {
        public static List<string> geussedWordsSoFar = new List<string>();
        public static int totalGeussesSoFar = 0;


        public static string GetRandomWord()
        {
            string[] wordPool = new string[] { "gorilla", "baboon", "butterfly", "pigeon", "parrot", "horse", "caterpillar", "sheep", "llama", "giraffe"};
            var rand = new Random();
            int index = rand.Next(wordPool.Length);            
            string randomWord = wordPool[index];                        
            return randomWord;
        }

        public static int GeussedWords(string geuss, int totalGeusses)
        {
            totalGeussesSoFar = totalGeusses;
            
            if (geussedWordsSoFar.Contains(geuss))
            {
                Console.WriteLine("You have already geussed this word");
            }

            else if (!geussedWordsSoFar.Contains(geuss))
            {
                geussedWordsSoFar.Add(geuss);
                ++totalGeusses;

            }

            Console.Write("Geussed words so far: ");
            foreach (var word in geussedWordsSoFar)
            {
            Console.Write($" {word},");
            }
            Console.WriteLine();
            return totalGeusses;
        }

        
    }
}

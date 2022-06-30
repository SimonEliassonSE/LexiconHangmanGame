using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconHangmanGame
{
    
    internal class DataClass
    {
        public static List<string> geussedWordsSoFar = new List<string>();
        public static int totalGeussesSoFar = 0;


        public static string GetRandomWord()
        {
            string[] wordPool = new string[] { "dog", "cat", "pig", "pigeons", "parrot", "horse", "cow", "sheep", "llama", "giraffe"};
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
            Console.Write($"{word}, ");
            }
            Console.WriteLine();
            return totalGeusses;
        }

        
    }
}

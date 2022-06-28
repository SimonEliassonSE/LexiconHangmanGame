using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconHangmanGame
{
    internal class DataClass
    {



        public static string GetRandomWord()
        {
            string[] wordPool = new string[] { "dog", "cat", "pig", "pigeons", "parrot", "horse", "cow", "sheep", "llama", "giraffe"};
            var rand = new Random();
            int index = rand.Next(wordPool.Length);            
            string randomWord = wordPool[index];                        
            return randomWord;
        }

    }
}

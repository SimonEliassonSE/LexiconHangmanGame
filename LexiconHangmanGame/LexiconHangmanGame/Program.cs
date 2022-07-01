using LexiconHangmanGame;
using System.Text;

// 2 DO ! Måste samla bokstäver gissade samt förhindra repetition av dessa ord inte skapar fler utfördagissningar
// om ordet är cow och man gissa a, a ,a så räknas alla 3 som utförda gissningar, skall bara bli 1 då resterande 2 är repetion av redan inmatade char
bool isDead = false;
while (!isDead)
{
    bool correctGeuss;
    bool alreadyGeussed;
    bool matchedFound;
    bool alreadyGeussedChar;
    int totalGeusses = 0;
    int maxGeusses = 10;    
    
    var randomWord = DataClass.GetRandomWord();
    char[] correctRandomCharArray = randomWord.ToCharArray();
    char[] userRandomWordArray = new char[randomWord.Length];
    StringBuilder previuslyGeussedChars = new StringBuilder();    
    for (int i = 0; i < correctRandomCharArray.Length; i++)
    {
        userRandomWordArray[i] = '_';
    }
    DisplayClass.GreetingDisplay();
    Console.ReadLine();
    
    
    do
    {   
        correctGeuss = false;
        alreadyGeussed = false;
        matchedFound = false;
        alreadyGeussedChar = false;
        DisplayClass.HangManIllustration(totalGeusses);
        Console.WriteLine();
        foreach (var item in userRandomWordArray)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();
        Console.WriteLine($"gessues used: {totalGeusses}");
        Console.WriteLine($"Already gessued char's: {previuslyGeussedChars}");
        Console.Write("Full word geussed so far: ");
        foreach (var item in DataClass.geussedWordsSoFar)
        {
            Console.Write($"{item} ,");
        }
        Console.WriteLine("\n");
        string playerGeuss = InputCollectingClass.GetUserGeuss().ToLower();       
        // Om playerInput är 1 längd så är det en char. 
        if (playerGeuss.Length == 1)
        {
            // konverterar stringen till en char för att kunna interagera med char arryerna 
            char c = Convert.ToChar(playerGeuss);
            alreadyGeussedChar = previuslyGeussedChars.ToString().Contains(c);

            // Kollar om input char finns i den tomma arrayen 
            for (int i = 0; i < userRandomWordArray.Length; i++)
            {                
                if (userRandomWordArray[i] == c)
                {
                    // Om input matchar den tomma arrayen, ändrar bool alreadyGeussed till true
                    alreadyGeussed = true;
                }
            }

            // Om redan gissad inte är san så kollas input mot den korrekta arrayen för och se om input stämmer med någon av bokstäverna
            if (!alreadyGeussed)
            {
                for (int i = 0; i < correctRandomCharArray.Length; i++)
                {
                    if(correctRandomCharArray[i] == c)
                    {
                        userRandomWordArray[i] = correctRandomCharArray[i];
                        
                        // Om input char matchade någon av charsen i den korrekta arrayen (ordet vi söker) så blir matchFound san
                        matchedFound = true;                        
                    }

                }
               
            }
            // Om ingen match funnits mot den korrekta arrayen ökas antalet felaktiga gissningar med 1 
            
            
                if (!matchedFound && !alreadyGeussed && !alreadyGeussedChar)
                {
                    // Lägger till fel ord i gissade ord.
                    previuslyGeussedChars.Append(c + ",");
                    totalGeusses++;
                }
            

            // Kollar för & se om alla bokstäverna har hittats, om så är fallet är spelet över
            if (matchedFound)
            {
                bool isEqual = Enumerable.SequenceEqual(userRandomWordArray, correctRandomCharArray);
                if (isEqual)
                {
                    Console.WriteLine("Congratulation you won the game!");
                    correctGeuss = true;
                }
            }       
       




        }

        else if (playerGeuss.Length > 1 && playerGeuss == randomWord)
        {
            Console.WriteLine("Congratulation! you gessued the correct word!");
            correctGeuss = true;

        }

        else if (playerGeuss.Length > 1 && playerGeuss != randomWord)
        {
             
            Console.WriteLine("You geussed the wrong word");
            correctGeuss = false;
            totalGeusses = DataClass.GeussedWords(playerGeuss, totalGeusses);
            
            
        }

        

        
    } while (!correctGeuss && totalGeusses != maxGeusses) ;
    if(totalGeusses == 10)
    {
        DisplayClass.HangManIllustration(10);        
        Console.WriteLine($"The correct word was: [{randomWord}]");
        Console.WriteLine();
        
    }
   isDead = DisplayClass.GoAgainDisplay();


}
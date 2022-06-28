using LexiconHangmanGame;
bool isDead = false;
while(!isDead)
{ 
DisplayClass.GreetingDisplay();
var randomWord = DataClass.GetRandomWord();


    Console.WriteLine("Test Hangman Illustration 1-10");
    string isItDead = Console.ReadLine();
    int isDeadInt = Convert.ToInt32(isItDead);
    DisplayClass.HangManIllustration(isDeadInt);
    Console.WriteLine("Go again [0] stop [11] ");
    string stopOrGo = Console.ReadLine();
    if (stopOrGo == "0")
    {
        isDead = false;
    }
    else if (stopOrGo == "11")
    {
        isDead = true;
    }

}
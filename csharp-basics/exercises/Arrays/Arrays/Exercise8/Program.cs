using System;

namespace Exercise8
{
    class Program
    {
        private static char [] wordToGuess = pickWord().ToCharArray();
        private static int wordToGuessLenght = wordToGuess.Length;
        private static char[] wordToDisplay = wordToBlank();
        private static string missedLetters="";
        private static int numberOfMisses = 0;
            
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome to a game of Hangman.\n" +
                "You have 10 chances to guess");
            while (true)
            {
                while (true)
                {                   
                    displayElements();
                    letterInput();
                    if (hasGameEnded())
                    {
                        break;
                    }

                }
                Console.Write("Do you want to play again?(PLAY / QUIT)  ");
                if (answerCheck("play", "quit"))
                {                    
                    resetGame();
                }
                else
                {
                    Environment.Exit(0);
                }                
            }           
        }
        private static void displayElements()       //Displays game to the player
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"\nWord: {String.Join(" ", wordToDisplay)}\n");
            Console.WriteLine($"Misses: {missedLetters}");
            Console.WriteLine(stateOfHangMan());
        }
        private static char [] wordToBlank() // Fills a blank word based of the wordToGuess
        {
            char [] wordToBlank = new char [wordToGuess.Length];           
            for (int i =0; i< wordToGuessLenght; i++)
            {
                wordToBlank[i] = '_';
            }
            return wordToBlank;
        }
        private static void letterInput()   // Checks the letter entered by player and compares it to previos letters
        {
            while (true)
            {
                Console.Write("Guess: ");
                char playerInput = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (!Char.IsLetter(playerInput))
                {
                    Console.WriteLine("Please input a letter.");

                }
                else if (missedLetters.IndexOf(playerInput) > -1 || Array.IndexOf(wordToDisplay,playerInput) > -1)
                {
                    Console.WriteLine("You already guessed this letter");
                }
                else
                {
                    checkWord(playerInput);
                    break;
                }


            }

        }
        private static bool answerCheck(string answer1, string answer2) // checks players answer to yes/no type question.
                                                                        // Answer1 returns true, answer 2 returns false
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == answer1.ToLower())
                {
                    return true;
                }
                else if (input == answer2.ToLower())
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Input is not correct");
                }
            }
        }

        private static void checkWord( char letter) //Checks if player has found a letter. If yes, then it places the letter in wordToDisplay.
                                                    //If not, then it adds the letter to missedLetters and increases the numberOfMisses
        {
            if (Array.IndexOf(wordToGuess, Char.ToLower(letter)) > -1)
            {
                for (int i = 0; i < wordToGuessLenght; i++)
                {
                    if (wordToGuess[i] == Char.ToLower(letter))
                    {
                        wordToDisplay[i] = letter;
                    }
                }
            }
            else
            {
                missedLetters += letter +" ";
                numberOfMisses++;
            }
           
        }
       
        private static bool hasGameEnded() //Checks if the game has ended by player reaching the max amount of missedLetters
                                           //or by player guessing the word
        {
            
            if (numberOfMisses == 10)
            {                
                displayElements();
                Console.WriteLine("You have lost. Do you want to see the word? (YES / NO)");
                if (answerCheck("yes", "no"))
                {
                    Console.WriteLine($"The word you tried to guess is: {String.Join(" ", wordToGuess)}");
                }                  
                return true;
            }
            else if (Array.IndexOf(wordToDisplay, '_')==-1)
            {                
                displayElements();
                Console.WriteLine("Congratulations! You have won!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void resetGame()  // Resets game by reseting all of the values used
        {
            wordToGuess = pickWord().ToCharArray();
            wordToGuessLenght = wordToGuess.Length;
            wordToDisplay = wordToBlank();
            missedLetters = "";
            numberOfMisses = 0;
        }
        private static string stateOfHangMan() //Changes the hangman logo based on numberOfMisses
        {
            switch (numberOfMisses)
            {
                default:
                    return 
                    "         \n"+
                    "         \n"+
                    "         \n" +
                    "         \n" +
                    "         \n" +
                    "#########\n"
                    ;
           

                case 1: 
                    return 
                    " |       \n" +
                    " |       \n" +
                    " |       \n" +
                    " |       \n" +
                    " |       \n" +
                    "#########\n"
                    ;
                case 2:
                    return
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    "#########\n"
                    ;

                case 3:
                    return
                    " +-----+ \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    "#########\n"
                    ;
                    
                case 4:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    "#########\n"
                    ;
                   
                case 5:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |   \\ | \n" +
                    "#########\n"
                    ;
                case 6:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " | / \\ | \n" +
                    "#########\n"
                    ;

                case 7:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " |  |  | \n" +
                    " | / \\ | \n" +
                    "#########\n"
                    ;
                case 8:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " | /|  | \n" +
                    " | / \\ | \n" +
                    "#########\n"
                    ;
                case 9:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " | /|\\ | \n" +
                    " | / \\ | \n" +
                    "#########\n"
                    ;

                case 10:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |  O  | \n" +
                    " | /|\\ | \n" +
                    " | / \\ | \n" +
                    "#########\n"
                    ;
                    

            }
        }

        private static string pickWord()  // Picks and returns a random word from the array words.
                                          // PS. DONT PEEK IN THE LIST!
        {
            var rand = new Random();
            string[] words = 
            { 
                "horse",
                "laptop",
                "counterstrike",
                "cat",
                "house",
                "seal",
                "horoscope",
                "photograph",
                "robot",
                "telephone",
                "hotdog",
                "crystal",
                "hospital",
                "chicken",
                "experience",
                "firefighter",
                "basketball",
                "stereotype",
                "discovery",
                "transmission",
                "suffering",
                "vehicle",
                "thought",
                "supermarket",
                "language",
                "heart",
                "inspiration",
                "apple",
                "computing",
                "terminal",
                "evolution",
                "relationship"
            };
            return words[rand.Next(0, words.Length - 1)].ToLower();
        }
    }
}

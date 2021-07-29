using System;

namespace Exercise8
{
    class Program
    {
        private static char [] wordToGuess = PickWord().ToCharArray();
        private static int wordToGuessLenght = wordToGuess.Length;
        private static char[] wordToDisplay = WordToBlank();
        private static string missedLetters="";
        private static int numberOfMisses = 0;
            
        static void Main(string[] args)
        {            
            
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Welcome to a game of Hangman.\n" +
                    $"You have {10-numberOfMisses} chances left to guess");
                    DisplayElements();
                    LetterInput();
                    if (HasGameEnded())
                    {
                        break;
                    }
                    Console.Clear();
                }
                Console.Write("Do you want to play again?(PLAY / QUIT)  ");
                while (true)
                {
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "play")
                    {
                        Console.Clear();
                        ResetGame();
                        break;
                    }
                    else if (answer=="quit") 
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input");
                    }
                }           
            }           
        }

        private static void DisplayElements()       //Displays game to the player
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"\nWord: {String.Join(" ", wordToDisplay)}\n");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
            Console.WriteLine($"Misses: {missedLetters}\n");
            Console.WriteLine(StateOfHangMan());
        }

        private static char [] WordToBlank() // Fills a blank word based of the wordToGuess
        {
            char [] wordToBlank = new char [wordToGuess.Length];
            for (int i = 0; i < wordToGuessLenght; i++)
            {
                wordToBlank[i] = '_';
            }
            return wordToBlank;
        }

        private static void LetterInput()   // Checks the letter entered by player and compares it to previos letters
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
                    CheckWord(playerInput);
                    break;
                }
            }
        }     
        
        private static void CheckWord( char letter)                     //Checks if player has found a letter. If yes, then it places the letter in wordToDisplay.                                                    
        {                                                               //If not, then it adds the letter to missedLetters and increases the numberOfMisses
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
        
        private static bool HasGameEnded()      //Checks if the game has ended by player reaching the max amount of missedLetters
        {                                       //or by player guessing the word
            if (numberOfMisses == 10)
            {
                Console.Clear();
                Console.WriteLine("Welcome to a game of Hangman.\n" +
                "The game has ended.");
                DisplayElements();
                Console.WriteLine("You have lost. Do you want to see the word? (YES / NO)");
                while (true)
                {
                    string answer = Console.ReadLine().ToLower();
                    if (answer== "yes")
                    {
                        Console.WriteLine($"The word you tried to guess is: {String.Join(" ", wordToGuess)}");
                        break;
                    }
                    else if (answer == "no")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorect input");
                    }
                }                        
                return true;
            }
            else if (Array.IndexOf(wordToDisplay, '_')==-1)
            {
                Console.Clear();
                Console.WriteLine("Welcome to a game of Hangman.\n" +
                "The game has ended.");
                DisplayElements();
                Console.WriteLine("Congratulations! You have won!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ResetGame()  // Resets game by reseting all of the values used
        {
            wordToGuess = PickWord().ToCharArray();
            wordToGuessLenght = wordToGuess.Length;
            wordToDisplay = WordToBlank();
            missedLetters = "";
            numberOfMisses = 0;
        }
        
        private static string StateOfHangMan() //Changes the hangman logo based on numberOfMisses
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
                    "#########\n";        
                case 1: 
                    return 
                    " |       \n" +
                    " |       \n" +
                    " |       \n" +
                    " |       \n" +
                    " |       \n" +
                    "#########\n";
                case 2:
                    return
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    "#########\n";
                case 3:
                    return
                    " +-----+ \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    "#########\n";                    
                case 4:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    "#########\n";                   
                case 5:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " |   \\ | \n" +
                    "#########\n";
                case 6:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " |     | \n" +
                    " | / \\ | \n" +
                    "#########\n";

                case 7:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " |  |  | \n" +
                    " | / \\ | \n" +
                    "#########\n";
                case 8:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " | /|  | \n" +
                    " | / \\ | \n" +
                    "#########\n";
                case 9:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |     | \n" +
                    " | /|\\ | \n" +
                    " | / \\ | \n" +
                    "#########\n";
                case 10:
                    return
                    " +--+--+ \n" +
                    " |  |  | \n" +
                    " |  O  | \n" +
                    " | /|\\ | \n" +
                    " | / \\ | \n" +
                    "#########\n";                   
            }
        }
        
        private static string PickWord()  // Picks and returns a random word from the array words.
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

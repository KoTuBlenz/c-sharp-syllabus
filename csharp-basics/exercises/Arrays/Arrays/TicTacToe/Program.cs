using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];    
        private static char playerSymbol = 'X'; 

        private static void Main(string[] args)
        {            
            InitBoard();
            while (true)
            {
                Console.WriteLine("Welcome to TicTacToe game. \n" +
                    new String('#', 75) + "\n" +
                    "The game is played by entering location to place X or O (for example 1 1)\n");               
                DisplayBoard();
                PlayerInput ();
                if (HasPlayerkWon())
                {
                                     
                    Console.Clear();
                    Console.WriteLine("Welcome to TicTacToe game. \n" +
                        new String('#', 75) + "\n" +
                        "The game has ended.\n");
                    DisplayBoard();
                    Console.WriteLine($"Congratulations! Player |{playerSymbol}| has won!");
                    break;
                }
                if (IsTie())
                {
                   
                                      
                    Console.Clear();
                    Console.WriteLine("Welcome to TicTacToe game. \n" +
                        new String('#', 75) + "\n" +
                        "The game has ended.\n");
                    DisplayBoard();
                    Console.WriteLine("The game is a tie /n");                                   
                    break;
                }
                playerSymbol = playerSymbol == 'X' ? 'O' : 'X';
                Console.Clear();
            }            
            Console.ReadKey();
        }
        
        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }            
        }
        
        private static void DisplayBoard()
        {
            Console.WriteLine("     0|1|2 ");
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
        
        private static void PlayerInput () // Checks players input and passes 2 numbers to addSymbolToBoard
        {
            int x;
            int y;
            
            while (true)
            {
                Console.WriteLine($"Enter location to place {playerSymbol}");
                x = -1;
                y = -1;
                char[] inputs= Console.ReadLine().ToCharArray();
                foreach (char num in inputs)
                {
                    if (Char.IsNumber(num))
                    {
                        if (x < 0)
                        {
                            int.TryParse(num.ToString(), out x);
                            continue;
                        }
                        else 
                        {
                            int.TryParse(num.ToString(), out y);
                            continue;
                        }
                        
                    }                    
                }                
                if ( x >=0 && y>=0)
                {
                    if (x > 2 || y > 2)
                    {
                        Console.WriteLine("One  or both of the numbers are too large (Max is 2)");
                    }
                    else if (x < 0 || y < 0)
                    {
                        Console.WriteLine("One or both of the numbers are too small (Min is 0)");
                    }
                    else if (board[x, y] != ' ')
                    {
                        Console.WriteLine("Place is already taken!");                        
                    }
                    else 
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Input is not correct. Please write 2 numbers");

                }
            }
            AddSymbolToBoard(x, y);           
        }
        
        private static void AddSymbolToBoard(int x, int y) //adds symbol to board based on x and y coordinates
        {
            board[x, y] = playerSymbol;
        }
        
        private static bool HasPlayerkWon()
        {
            //Checks horizontal lines for player symbols
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == playerSymbol && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true;
                }
            }
            //Checks vertical lines for player symbols
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == playerSymbol && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return true;
                }
            }
            // Checks both diagonals
            if (board[0, 0] == playerSymbol && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] ||
                board[0, 2] == playerSymbol && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true;
            }            
            return false;
        }            
        
        private static bool IsTie()  // checks if the board is full and if its a tie
        {            
            for (var i = 0; i < 3; i++)
            {
                for (var k = 0; k < 3; k++)
                {
                    if (board[i,k] == ' ')
                    {
                        return false;
                    }
                }                      
            }
            return true;
        }
    }
}

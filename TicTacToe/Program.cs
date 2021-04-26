using System;

namespace TicTacToe
{
    class Program
    {
        static string[,] board =
            {
                {"1","2","3" },
                {"4","5","6" },
                {"7","8","9" }
            };

        static void Main(string[] args)
        {
            PrintBoard();

            bool running = true;
            int turn = 1;
            while (running)
            {
                if (turn % 2 != 0)
                {
                    Console.WriteLine("Player 1: pick your position: ");
                    string player1Input = Console.ReadLine();
                    while(!ChangeName(player1Input, "X"))
                    {
                        Console.WriteLine("Please choose a valid position: ");
                        player1Input = Console.ReadLine();
                    }
                    PrintBoard();
                    Console.WriteLine("\n");
                    if (CheckWinner("Player 1"))
                    {
                        running = false;
                    }
                    turn++;
                }
                else
                {
                    Console.WriteLine("Player 2: pick your position: ");
                    string player2Input = Console.ReadLine();
                    while (!ChangeName(player2Input, "O"))
                    {
                        Console.WriteLine("Please choose a valid position: ");
                        player2Input = Console.ReadLine();
                    }
                    
                    PrintBoard();
                    Console.WriteLine("\n");
                    if (CheckWinner("Player 2"))
                    {
                        running = false;
                    }
                    turn++;
                }
            }

        }
        static void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("| " + board[i, j] + " |");
                    }
                    else
                    {
                        Console.Write(" " + board[i, j] + " ");
                    }

                }
                Console.Write("\n");
            }
        }

        static bool ChangeName(string answer, string mark)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                      if (board[i, j] == answer)
                      {
                        if (int.TryParse(board[i,j], out int n))
                        {
                            board[i, j] = mark;
                            return true;
                        }  
                      }
                    

                }
            }
            return false;
        }

        static bool CheckWinner(string playerNum)
        {
            if (board[0, 0] == board[1,0] && board[1,0] == board[2, 0])
            {
                Console.WriteLine("{0} is the winner!!", playerNum);
                return true;
            }
            else if (board[0, 1] == board[1,1] && board[1,1] == board[2, 1])
            {
                Console.WriteLine("{0} is the winner!!", playerNum);
                return true;
            } else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                Console.WriteLine("{0} is the winner!!", playerNum);
                return true;
            }
            else if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
            {
                Console.WriteLine("{0} is the winner!!", playerNum);
                return true;
            } 
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                Console.WriteLine("{0} is the winner!!", playerNum);
                return true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                Console.WriteLine("{0} is the winner!!", playerNum);
                return true;
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                Console.WriteLine("{0} is the winner!!", playerNum);
                return true;
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                Console.WriteLine("{0} is the winner!!", playerNum);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

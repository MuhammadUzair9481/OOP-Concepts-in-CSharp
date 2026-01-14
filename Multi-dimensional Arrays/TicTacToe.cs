using System;
class TicTacToe
{
    static void Main(string[] args)
    {
         char[,] board = new char[3, 3];
        Console.WriteLine("\nArray looks like:");

     for (int i = 0   < 3; i++)
     {
        for (int j   ; j < 3; j++)
        {
        board[i, j] = '-';        
        }
    
     }
        char currentPlayer = 'X';       
        
        while(true)
        {   
             // board look like
         
         for (int i = 0; i < 3; i++)
         {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        
         }
         Console.WriteLine("current player turn : " + currentPlayer);
            Console.Write("enter row (0-2) : ");
            int row = int.Parse(Console.ReadLine());
            if (row < 0 || row >= 3)
            {
                 Console.Write("your input out of range");
                continue;
            }
            Console.Write(" Enter column (0-2): ");
            int col = int.Parse(Console.ReadLine());
            if (col < 0 || col >= 3)
            {
             Console.Write("your input out of range :");
                continue;
            }             

            //for empty board chekc

            if(board[row,col] != '-')
            {
                Console.WriteLine("the space is filled : ");
                continue;
            }            
            board[row,col] = currentPlayer;                
        
           

            //for winning cases
         bool CheckRows()
         {
            for (int i = 0; i < 3; i++)
            {
                if (board[i,0] == board[i,1] &&
                board[i,1] == board[i,2] &&
                board[i,0] != '-')
                    {
                        Console.WriteLine("Player " + board[i,0] + " wins by row!");
                        return true;
                    }
            }

            return false;
         }
         bool Checkcols()
         {
            for (int i = 0; i < 3; i++)
            {
                if (board[0,i] == board[1,i] &&
                board[1,i] == board[2,i] &&
                board[0,i] != '-')
                    {
                        Console.WriteLine("Player " + board[0,i] + " wins by cols!");
                        return true;
                    }
            }

            return false;
         }
         bool CheckDiagonals()
            {
            
                if (board[0,0] == board[1,1] &&
                    board[1,1] == board[2,2] &&
                    board[0,0] != '-')
                {
                    Console.WriteLine($"Player {board[0,0]} wins by diagonal!");
                    return true;
                }

                
                if (board[0,2] == board[1,1] &&
                    board[1,1] == board[2,0] &&
                    board[0,2] != '-')
                {
                    Console.WriteLine($"Player {board[0,2]} wins by diagonal!");
                    return true;
                }

                return false;
            }
             bool IsBoardFull()
             {
                 for (int i = 0; i < 3; i++)
                     for (int j = 0; j < 3; j++)
                        if (board[i,j] == '-')
                          return false;

                 return true;
             }

           
         if (CheckRows()|| Checkcols()||CheckDiagonals())
            { Console.WriteLine("\nGame Over 🎉");
                break;
            }

        if (IsBoardFull())
            {               
                Console.WriteLine("Game Draw!");
                break;
            }
         if (currentPlayer == 'X')
                currentPlayer = 'O';
         else
                currentPlayer = 'X';



        } 
    }   
}

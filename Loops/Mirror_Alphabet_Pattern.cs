     //     A 
     //    ABA
     //   ABCBA
     //  ABCDCBA
     // ABCDEDCBA
     //  ABCDCBA
     //   ABCBA
     //    ABA
     //     A

using System;

public class Pattern
{
    static void Main(string[] args)
    {    
              int n = 5;
             
             for (int i = 1; i <= n; i++)
             {
                 Console.Write(new string(' ', n - i));
                
                 for (int j = 0; j < i; j++)
                 {
                     Console.Write((char)('A' + j));
                 }
                 
                 for (int j = i - 2; j >= 0; j--)
                 {
                     Console.Write((char)('A' + j));
                 }

                 Console.WriteLine();
             }

             for (int i = n-1 ; i >= 1 ; i--)
             {
                 Console.Write(new string(' ', n - i));

                 for (int j = 0 ; j < i ;j++ )
                 {
                    Console.Write((char)('A' + j)); 
                 }
                
                 for (int j = i - 2; j >= 0; j--)
                 {
                     Console.Write((char)('A' + j));
                 }

                 Console.WriteLine();
               }
    }
}

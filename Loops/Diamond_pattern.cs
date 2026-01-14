     //     a
     //    aaa
     //   aaaaa
     //  aaaaaaa
     // aaaaaaaaa
     //  aaaaaaa
     //   aaaaa
     //    aaa
     //     a

         
using System;
public class Pattern
{
    static void Main(string[] args)
    {       
        int spaces ,stars ;
        int n = 9 ;
        for (int i=1 ; i <= n ;i++)
         { 
             if( i <= 5 )
             {
                 spaces = 5 - i ;
                 stars = 2*i -1 ;                
             }
             else
             {
                 spaces = i - 5 ;
                 stars = 2 * (n-i +1) - 1 ;
             }
               Console.WriteLine(new string(' ', spaces) + new string('a', stars));            
         }

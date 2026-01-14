     //      1    
     //    1 2 1     
     //   1 2 3 2 1
     //  1 2 3 4 3 2 1
     // 1 2 3 4 5 4 3 2 1

using system;
public class pattern{
   static void Main(string[] args)
    { 

     int n = 5 ;
     int spaces;
      
     for (int i = 1; i <= n ;i++)
     {
         spaces = n - i;
         Console.Write(new string(' ', spaces));
       
         for (int j = 1; j <= i; j++)
         { 
             Console.Write(j +" ")  ;
         }
         for (int k = i-1; k >= 1 ;k--)
         {
              
             Console.Write(k + " ");
         } 
           
         Console.WriteLine();
     }
}

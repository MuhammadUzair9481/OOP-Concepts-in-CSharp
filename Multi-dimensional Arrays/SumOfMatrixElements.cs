

using System;
public class Matrixaddition
{
    static void Main (string[]args)
    {
        int [,] matrix =new int[3,3];
        
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {

                Console.Write("Enter element[{0},{1}]: ", i, j);
                 matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                sum = sum + matrix[i, j]; 

            }
        
         }   
        Console.WriteLine("\nThe total sum of all elements is: " + sum);
    }

}

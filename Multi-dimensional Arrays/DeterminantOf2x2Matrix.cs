
// IN which the input is taken by User

using System;
class Program
{
    static void Main()
    {
        // Define a 2x2 matrix
        int[,] matrix = new int[2, 2];

        // Input values from the user
        Console.WriteLine("Enter 4 elements of the 2x2 matrix:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Calculate determinant
        int determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);

        // Display result
        Console.WriteLine($"Determinant of the matrix is: {determinant}");
    }
}


 // ## In which the value is pre describe


using System;

class Program
{
    static void Main()
    {
        int[,] matrix =
        {
            { 2, 3 },
            { 4, 5 }
        };

        
        int determinant = (matrix[0, 0] * matrix[1, 1])  - (matrix[0, 1] * matrix[1, 0]);

        // Display result
        Console.WriteLine("Determinant of the matrix is: " + determinant);
    }
}





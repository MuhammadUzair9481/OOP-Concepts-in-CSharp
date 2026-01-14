using System;

public class Test
{
   public static void Main()
   {
    Console.Write("enter the number of items ");
    int n = int.Parse(Console.ReadLine());
    double []numbers = new double [n];
    double sum = 0;
    
    for (int i=0;i < n ; i++)
        {   Console.Write("enter the numbers ");
            numbers[i] =double.Parse( Console.ReadLine());
            sum += numbers[i];            
        }
        double average = sum/n;

     //  now we find the number which is greater than average 
     int count = 0;
     for (int i =0 ; i< n;i++)
     {
        if (numbers[i] > average)
            {   
                count++ ;
            
            }
     }
     Console.WriteLine("average  " + average);
     Console.WriteLine("the numbers which is greater than average  " + count);
    }
}


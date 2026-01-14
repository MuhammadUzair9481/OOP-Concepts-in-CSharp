using System;

class CountOccurrences
{
    static void Main()
    {
        int[] counts = new int[101];
        Console.WriteLine("Enter numbers between 1 and 100 (enter 0 to stop):");

        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            
            if (num == 0)
                break;
           
            if (num >= 1 && num <= 100)
            {
                counts[num]++;
            }
        }
      
        for (int i = 1; i <= 100; i++)
        {
            if (counts[i] > 0)
            {
                if (counts[i] == 1)
                    Console.WriteLine($"{i} occurs {counts[i]} time");
                else
                    Console.WriteLine($"{i} occurs {counts[i]} times");
            }
        }
    }
}

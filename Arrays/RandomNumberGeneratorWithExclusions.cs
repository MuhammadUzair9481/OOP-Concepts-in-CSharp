class Program
{
    static void Main()
    {
        Random rand = new Random(); 
        int count = 90;   
        int start = 1;
        int end = 100;
        int[] excluded = { 4, 8, 95, 93 };

        for (int i = 1; i <= count; i++)
        {
            int num;

            while (true) // loop until we find a number not in excluded
            {
                num = rand.Next(start, end + 1); 
              
                bool isExcluded = false;
              
                for (int j = 0; j < excluded.Length; j++)
                {
                    if (num == excluded[j])
                    {
                        isExcluded = true;
                        break;
                    }
                }

                if (!isExcluded)
                    break; 
            }

            Console.Write($"{num,4}");

            if (i % 15 == 0) 
                Console.WriteLine();
        }
    }
}

using System;

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // String input = Console.ReadLine();
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.None);

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int n = int.Parse(input[2]);

            for (int i = 1; i < n + 1; i++)
            {

                Console.WriteLine(i);
            }

           
            
            Console.ReadLine();
        }
    }
}

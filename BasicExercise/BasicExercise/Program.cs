using System;
namespace BasicExercise
{
    class Program
    { 
        public static void Main(string[] args)
        {
            int lines;
            Console.WriteLine("Enter number of lines : ");
            lines = Int32.Parse(Console.ReadLine());
            Console.WriteLine(lines);
            for (int i = 1; i <= lines; i++)
            {
                int maxj = 2 * i - 1;
                char ch = 'A';
                ch = (char)(ch - 1);
                for (int j = 0; j < maxj; j++)
                {
                    if (j <=(int)Math.Floor( maxj / 2.0))
                    {
                        ch = (char)(ch+1);
                        Console.Write(ch);
                    }
                    else
                    {
                        ch = (char)(ch - 1);
                        Console.Write(ch);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
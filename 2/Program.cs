namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= i)
                        Console.Write(" *");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}

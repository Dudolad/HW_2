namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n - i - 1)
                        Console.Write(" *");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }   
    }
}

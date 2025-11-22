namespace _6
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
                    bool left = (j <= i && j < n - i);

                    bool right = (j >= n - i - 1 && j >= i);

                    if (left || right)
                        Console.Write(" *");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }
}

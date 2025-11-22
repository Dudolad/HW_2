namespace _5
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
                    bool top = (j >= i && j < n - i);
                    bool bottom = (j >= n - i - 1 && j <= i);

                    if (top || bottom)
                        Console.Write(" *");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }
}

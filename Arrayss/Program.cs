namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 4, 2 }, { 3, 6, 9 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("---- The number is DateOnly[0,1] position ");
            Console.WriteLine(matrix[0, 1]);

            string[,] matrix2 = { { "one", "four", "two" }, { "three", "six", "eight" } };
            Console.WriteLine("---- The second (string) matrix");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.WriteLine(matrix2[i, j] + "\t");

                }
                Console.WriteLine();
            }

        }
    }
}

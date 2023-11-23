 static void Main()
    {
        Console.WriteLine("Введите количество строк N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов M:");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        Console.WriteLine("Введите элементы матрицы:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int[] minElements = new int[n];
        for (int i = 0; i < n; i++)
        {
            int minElement = matrix[i, 0];
            for (int j = 1; j < m; j++)
            {
                if (matrix[i, j] < minElement)
                {
                    minElement = matrix[i, j];
                }
            }
            minElements[i] = minElement;
        }
        for (int i = 0; i < n; i++)
        {
            matrix[i, 0] = minElements[i];
        }
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix, n, m);

        Console.ReadLine();
    }
    static void PrintMatrix(int[,] matrix, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
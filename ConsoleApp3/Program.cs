using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.WriteLine(" ЗАДАНИЕ 1 ");

        int rows1 = 3;
        int cols1 = 5;
        int[,] array1 = new int[rows1, cols1];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                array1[i, j] = random.Next(10, 21);
            }
        }

        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                Console.Write($"{array1[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.Write("Введите номер строки: ");
        int userRow = int.Parse(Console.ReadLine());
        int rowIndex = userRow - 1; 

        if (rowIndex >= 0 && rowIndex < rows1)
        {
            int sumRow = 0;
            for (int j = 0; j < cols1; j++)
            {
                sumRow += array1[rowIndex, j];
            }
            Console.WriteLine($"Сумма элементов строки = {sumRow}");
        }
        else
        {
            Console.WriteLine($"Ошибка: номер строки должен быть от 1 до {rows1}.");
        }

        Console.WriteLine("\n ЗАДАНИЕ 2 ");

        int rows2 = 3;
        int cols2 = 4;
        int[,] array2 = new int[rows2, cols2];

        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                array2[i, j] = random.Next(10, 101);
            }
        }

        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write($"{array2[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int maxSum = 0;
        int maxColumnIndex = -1;

        for (int j = 0; j < cols2; j++)
        {
            int colSum = 0;
            for (int i = 0; i < rows2; i++)
            {
                colSum += array2[i, j];
            }

            Console.WriteLine($"Сумма {j + 1} столбца = {colSum}");

            if (colSum > maxSum)
            {
                maxSum = colSum;
                maxColumnIndex = j + 1;
            }
        }

        Console.WriteLine($"Столбец с максимальной суммой = {maxColumnIndex}");
        Console.WriteLine($"Максимальная сумма = {maxSum}");

        Console.WriteLine("\nЗАДАНИЕ 3 ");

        int size = 3;
        int[,] matrix = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = random.Next(-10, 11);
            }
        }

        Console.WriteLine("Матрица:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Положительные элементы главной диагонали:");
        string mainDiagonalPositives = "";
        bool hasMainPositives = false;

        for (int i = 0; i < size; i++)
        {
            int value = matrix[i, i];
            if (value > 0)
            {
                mainDiagonalPositives += $"{value} ";
                hasMainPositives = true;
            }
        }

        if (hasMainPositives)
        {
            Console.WriteLine(mainDiagonalPositives);
        }
        else
        {
            Console.WriteLine("Положительных элементов на главной диагонали нет.");
        }
        Console.WriteLine();

        Console.WriteLine("Положительные элементы побочной диагонали:");
        string sideDiagonalPositives = "";
        bool hasSidePositives = false;

        for (int i = 0; i < size; i++)
        {
            int value = matrix[i, size - 1 - i];
            if (value > 0)
            {
                sideDiagonalPositives += $"{value} ";
                hasSidePositives = true;
            }
        }

        if (hasSidePositives)
        {
            Console.WriteLine(sideDiagonalPositives);
        }
        else
        {
            Console.WriteLine("Положительных элементов на побочной диагонали нет.");
        }
    }
}

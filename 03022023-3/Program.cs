Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();

void FulltArray(int[,] arrayArithMean)
{for (int i=0; i < arrayArithMean.GetLength(0); i++)
    {for (int j=0; j < arrayArithMean.GetLength(1); j++)
          {
            arrayArithMean[i, j] = new Random().Next(0, 100);
          }
    }
    return;
}
Console.WriteLine("Сформирован массив:  ");
void PrintArray(int[,] arrayArithMean)
{for(int i=0; i < arrayArithMean.GetLength(0); i++)
    {for (int j=0; j < arrayArithMean.GetLength(1); j++)
        {
           Console.Write($"{arrayArithMean[i, j]} \t ");
        }
      Console.WriteLine();
    }
}
int [,] arrayArithmeticMean = new int [4, 4];

FulltArray(arrayArithmeticMean);
PrintArray(arrayArithmeticMean);

void ColumnsArray(int[,] arrayArithMean)

{

    for (int i = 0; i < arrayArithMean.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arrayArithMean.GetLength(0); j++)
        {
            sum = sum + arrayArithMean[j, i];
        }
        sum = sum / arrayArithMean.GetLength(0);

        Console.WriteLine($"Среднее арифметическое значение столбца {i + 1} массива равно {sum.ToString("0.00")}");

    }

}
ColumnsArray(arrayArithmeticMean);
Console.WriteLine("Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");

//m = 3, n = 4.

Console.WriteLine();

void FulltArray(double[,] arrayRealNumber)
{for (int i=0; i < arrayRealNumber.GetLength(0); i++)
    {for (int j=0; j < arrayRealNumber.GetLength(1); j++)
          {
            arrayRealNumber[i, j] = new Random().Next(-9, 10);
          }
    }
    return;
}

void PrintArray(double[,] arrayRealNumber)
{for(int i=0; i < arrayRealNumber.GetLength(0); i++)
    {for (int j=0; j < arrayRealNumber.GetLength(1); j++)
          {
            Console.Write("{0, 4}\t", arrayRealNumber[i, j].ToString("0.00"));
          }
    Console.WriteLine();
    }
}


double [,] arrayRealNumbers = new double [5, 8];
FulltArray(arrayRealNumbers);
PrintArray(arrayRealNumbers);
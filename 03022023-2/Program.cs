Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine();
int row, col;
Console.Write("Введите значение индекса строки элемента массива, начиная с 0:  ");
while (!Int32.TryParse(Console.ReadLine(), out row))
    Console.Write("Неправильный ввод. Введите целое положительное число: ");

Console.Write("Введите значение индекса столбца элемента массива, начиная с 0 :  ");
while (!Int32.TryParse(Console.ReadLine(), out col))
        Console.Write("Неправильный ввод. Введите целое число: ");

void FulltArray(int[,] arrayElementSearch)
{for (int i=0; i < arrayElementSearch.GetLength(0); i++)
    {for (int j=0; j < arrayElementSearch.GetLength(1); j++)
          {
            arrayElementSearch[i, j] = new Random().Next(-100, 100);
          }
    }
    return;
}
Console.WriteLine("Сформирован массив:  ");
void PrintArray(int[,] arrayElementSearch)
{for(int i=0; i < arrayElementSearch.GetLength(0); i++)
    {for (int j=0; j < arrayElementSearch.GetLength(1); j++)
        {
           Console.Write($"{arrayElementSearch[i, j]} \t");
        }
      Console.WriteLine();
    }
}
int [,] arrayElementsSearch = new int [8, 8];

FulltArray(arrayElementsSearch);
PrintArray(arrayElementsSearch);

if (row<arrayElementsSearch.GetLength(0) && col<arrayElementsSearch.GetLength (1)) 
{
    Console.WriteLine($"Значение элемента на {row+1} строке в {col+1} столбце равно - {arrayElementsSearch[row, col]} ");
}
else 
{
Console.WriteLine("В данном массиве отсутсвует элемент с указанными позициями.");
}


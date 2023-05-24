// Task 2. Задайте двумерный массив. Напишите программу, которая меняет местами любые две строчки массива.
// void

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// Console.Write("Input quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input quantity of min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input quantity of max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

void Show2dArray(int[,] array)

{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


// void RandomChangeRows(int[,] array, int row1, int row2)
// {
//     if(row1<array.GetLength(0) && row2<array.GetLength(0) && row1 >=0 && row2 >=0)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//                 int temp = array[row1,j];
//                 array[row1,j] = array[row2,j];
//                 array[row2,j] = temp;
//         }
//     }
// }

// Console.WriteLine("Input first row:");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second row, which need change:");
// int row2 = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// RandomChangeRows(myArray, row1, row2);
// Show2dArray(myArray);


// Task 3. Из двумерного массива чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.


// int[] MinItem(int[,] array)
// {
//     int min = array[0,0];
//     int minX = 0;
//     int minY = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i,j] < min)
//             {
//                 min = array[i,j];
//                 minX = i;
//                 minY = j;
//             }
//         }
//     }
//     int[] coord = {minX, minY};
//     return coord;
// }

// void DeleteRowAndColumn(int[,] array, int[] coord)
// {
//     for(int i = 0; i < array.GetLength(0); i++) array[i, coord[1]] = 0;
//     for(int j = 0; j < array.GetLength(1); j++) array[coord[0], j] = 0;
// }

// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// int[] result = MinItem(myArray);
// DeleteRowAndColumn(myArray, result);
// Show2dArray(myArray);

// HOMEWORK at seminar 8. 
// Task 54++. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void SortRows(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
//             for(int k = 0; k<array.GetLength(1) - 1; k++)
//             {
//                 if(array[i, k] < array[i, k+1])
//                 {
//                     int temp = array[i,k];
//                     array[i,k] = array[i, k+1];
//                     array[i,k+1] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// SortRows(myArray);
// Show2dArray(myArray);

// Task 56+: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void RowMinItems(int[,] array)
// {
//     int min = 0;
//     int minRow = 0;
//     int current = 0;
//     for(int j = 0; j < array.GetLength(1); j++) min += array[0,j];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++) minRow += array[i,j];
//         if(minRow < min)
//         {
//             min = minRow;
//             current = i;
//         }
//         minRow = 0;
//     }
//     Console.WriteLine($"Строка {current + 1}");
// }

// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// RowMinItems(myArray);

// Task 58+: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// void FillArray(int[,] table)
// {
//     for(int i = 0; i<table.GetLength(0); i++)
//         for(int j = 0; j<table.GetLength(1); j++)
//             table[i,j] = new Random().Next(1, 9); 
// }

// int[,] resultTable = new int[2,2];
// void ProdMatrix(int[,] table1, int[,] table2)
// {
    
//     if(table1.GetLength(0) != table2.GetLength(1))
//     {
//         Console.WriteLine("Нельзя перемножить");
//         return;
//     }
//     for(int i = 0; i<table1.GetLength(0); i++)
//     {
//         for(int k = 0; k<table2.GetLength(1); k++)
//         {
//             resultTable[i,k] = 0;
//             for(int j = 0; j<table1.GetLength(1); j++)
//             {
//                 resultTable[i,k] += table1[i,j] * table2[j,k];
//             }
//         }
//     }    
// }

// int[,] table1 = new int[2,2];
// FillArray(table1);
// Show2dArray(table1);
// int[,] table2 = new int[2,2];
// FillArray(table2);
// Show2dArray(table2);
// ProdMatrix(table1, table2);
// Show2dArray(resultTable);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.



// Task 62+. Напишите программу, которая заполнит спирально любой двумерный массив.

int n = 4;
int[,] array = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

Show2dArray(array);



// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[n, m];

// int temp = 1;
// int i = 0;
// int j = 0;
// int highBoardRow = n - 1;
// int highBoardColumn = m - 1;
// int lowBoardRow = 0;
// int lowBoardColumn = 0;

// while (temp <= array.GetLength(0) * array.GetLength(1))
// {
//   array[i, j] = temp;
//   for(j = lowBoardColumn; j<=highBoardColumn; j++)
//     {
//       temp++;
//       array[i, j] = temp;
//     }
//   for(i = lowBoardRow; i<=highBoardRow; i++)
//     {
//       temp++;
//       array[i, j] = temp;
//     }
//   for(j = highBoardColumn; j>=lowBoardColumn; j--)
//     {
//       temp++;
//       array[i, j] = temp;
//     }
//   for(i = highBoardRow; i>=lowBoardRow; i--)
//     {
//       temp++;
//       array[i, j] = temp;
//     }
  
//   highBoardColumn -= 1;
//   highBoardRow -=1;
//   lowBoardColumn += 1;
//   lowBoardRow += 1;
// }

// Show2dArray(array);


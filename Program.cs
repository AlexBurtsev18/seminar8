// Task 2. Задайте двумерный массив. Напишите программу, которая меняет местами любые две строчки массива.
// void

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

Console.Write("Input quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity of min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

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
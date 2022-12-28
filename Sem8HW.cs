// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,columns];
//     for (int i=0; i<rows;i++);
//     {
//         for (int j=0; j<columns;j++);
//         {
//         newArray[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray;
// }
// void Show2DArray (int[,]array)
// {
//     for (int i=0; i< array.GetLenght(0);i++);
//     {
//         for (int j=0; j<array.GetLenght(1);j++);
//         {
//         Console.Write(array[i,j]+ " "); 
//         }
//     Console.WriteLine();
//     }
// }
// void SortInRow(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) -1 ; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.Write("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива");
// doub min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение массива");
// doub max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray (myArray);
// SortInRow (myArray);


// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,columns];
//     for (int i=0; i<rows;i++);
//     {
//         for (int j=0; j<columns;j++);
//         {
//         newArray[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray;
// }
// void Show2DArray (int[,]array)
// {
//     for (int i=0; i< array.GetLenght(0);i++);
//     {
//         for (int j=0; j<array.GetLenght(1);j++);
//         {
//         Console.Write(array[i,j]+ " "); 
//         }
//     Console.WriteLine();
//     }
// }
// int MinSumInRow(int[,] array)
//  int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minRow += array[0, i];
//     }
//     for (int i = 0; i <  array.GetLength(0); i++)
//     {
//         for (int j = 0; j <  array.GetLength(1); j++) sumRow += array[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//             Console.WriteLine($"Номер строки с минимальной суммой элементов - {i}");

//         return i;
//         }
//         sumRow = 0;


// Console.Write("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива");
// doub min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение массива");
// doub max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray (myArray);
// MinSumInRow (myArray);





// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,] Create3DArray (int rows, int columns, int h, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,columns,h];
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int h = 0; h < arr.GetLength(2); h++)
//             {
//                 arr[h, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }
//     return newArray;
// }
// void Show3DArray (int[,]array)
// {
//      for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int h = 0; h < arr.GetLength(2); h++)
//         {
//         Console.Write(array[i,j,h]+ " "); 
//         }
//     Console.WriteLine();
//     }
// }
// void ShowIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int h = 0; k < array3D.GetLength(2); h++)
//             {
//                 Console.Write($"Построен 3-х мерный массив {array3D[i, j, k]} с индексами({i},{j},{k}) ");
//             }
//         }
//     }
// }


// Console.Write("Введите количество строк");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов");
// int j = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третью координату");
// int h  = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива");
// doub min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение массива");
// doub max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create3DArray(i,j,h,min,max);
// Show3DArray (myArray);
// ShowIndex (myArray);





// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// int[,] Create2DFirstArray (int rows1, int columns1, int minValue1, int maxValue1)
// {
//     int[,] newArray = new int[rows,columns];
//     for (int i=0; i<rows;i++);
//     {
//         for (int j=0; j<columns;j++);
//         {
//         newArray[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray1;


// int[,] Create2DSecondArray (int rows2, int columns2, int minValue2, int maxValue2)
// {
//     int[,] newArray = new int[rows,columns];
//     for (int m=0; m<rows;i++);
//     {
//         for (int n=0; n<columns;n++);
//         {
//         newArray[m,n] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray2;

// int [,] TwoMatrix (new array1, new array2)
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int m = 0; m < array.GetLength(1); m++)
//         {
//             resultArray[i, j] += newarray2[m, i] * newArray1[n, j];
            // Console WriteLine($"Результат произведения двух матриц - {resultArray[i, j]}")
//          }
// return resultArray;
//     }
// }
// Console.Write("Введите количество строк первого массива");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов первого массива");
// int j = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк второго массива");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов второго массива");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение первого массива");
// minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение первого массива");
// maxValue1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение второго массива");
// minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение второго массива");
// maxValue1 = Convert.ToInt32(Console.ReadLine());



// int[,] myArray = int[,] Create2DFirstArray(i,j,min,max);
// int[,] myArray = int[,] Create2DSecondArray(m,n,min,max);
// int [,] TwoMatrix (new array1, new array2)
// Show3DArray (myArray);
// ShowIndex (myArray);



// ЗАДАЧУ ПРО СПИРАЛЬНЫЙ МАССИВ ЧЕСТНО НЕ ПОНЯЛ






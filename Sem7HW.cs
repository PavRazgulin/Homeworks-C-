// 

// int[,] Create2DRandomArray (int rows, int columns, doub minValue, doub maxValue)
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
//     for (doub i=0; i< array.GetLenght(0);i++);
//     {
//         for (doub j=0; j<array.GetLenght(1);j++);
//         {
//         Console.Write(array[i,j]+ " "); 
//         }
//     Console.WriteLine();
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


// // Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

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

// int[,] CheckCell (int [,]array)
// // {
// //     int[,] newArray = new int[rows,columns];
// //     for (int i=0; i<rows;i++);
// //     {
// //         for (int j=0; j<columns;j++);
// //         {
// //         if (i==r && j==c)
//                result=Console.WriteLine($"Введенное значение {i,j} существует в массиве")
// //         }
// //          else result=Console.WriteLine($"Введенное значение {i,j} не существует в массиве")
//         return result;     


// Console.Write("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение массива");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер строки");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца");
// int с = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray (myArray);
// CheckCell (myArray);






// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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

// int[,] MidMath (int [,]array)
//  {
//      for (int j=0; j<array.GetLenght(1);j++);
//               Mid=0
//         result=Mid+j % array.Lenght;
//         return result;     
//  }

// Console.Write("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение столбца");
// int j = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение массива");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray (myArray);
// MidMath (myArray);
// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2


// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int []myArray = new int[size];
//     for (int i=0; i<size;i++);
//     {
//         myArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return myArray;
// }
// void ShowArray (int[]array)
// {
//     Console.WriteLine("Полученный массив->");
//     for (int i=0; i<array.Lenght;i++);
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// int[] CountNumbers (int size, int minValue, int maxValue)
// {
//     int []myArray = new int[size];
//      int Count=0;
//     for (int i=0; i<size;i++);
//     {
//              if (i%2)>0;
//        {
//         int result= i+Count;
//        }
         
//      }
//     return result;
// Console.WriteLine($"Количество чётных чисел в массиве - {result}");
// }


// Console.WriteLine("Введите размер массива");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива - от 100");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива - до 998");
// int lenght = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(lenght,min,max);
// ShowArray (newArray);
// CountNumbers (newArray);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int []myArray = new int[size];
//     for (int i=0; i<size;i++);
//     {
//         myArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return myArray;
// }
// void ShowArray (int[]array)
// {
//     Console.WriteLine("Полученный массив->");
//     for (int i=0; i<array.Lenght;i++);
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// int[] Sum (int size, int minValue, int maxValue)
// {
//     int []myArray = new int[size];
//      int sum=0;
//     for (int i=0; i<size;i++);
//     {
//              if (i%2)<0;
//        {
//             int result= i+Sum;
//        }
//     }
//     return result;
// Console.WriteLine($"Сумма нечётных чисел в массиве - {result}");
// }


// Console.WriteLine("Введите размер массива");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива ");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива");
// int lenght = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(lenght,min,max);
// ShowArray (newArray);
// Sum (newArray);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

doub[] CreateRandomArray (int size, doub minValue, doub maxValue)
// {
//     doub []myArray = new int[size];
//     for (doub i=0; i<size;i++);
//     {
//         myArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return myArray;
// }
// void ShowArray (int[]array)
// {
//     Console.WriteLine("Полученный массив->");
//     for (doub i=0; i<array.Lenght;i++);
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// void[] Diff (int size, doub minValue, doub maxValue)
// {
//     doub []myArray = new int[size];
//     doub Diff= doub maxValue-doub minValue;

//Console.WriteLine($"Разница между максимальным и минимальным элементов в массиве равна {doub Diff}");
// }


// Console.WriteLine("Введите размер массива");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива ");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение массива");
// int lenght = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(lenght,min,max);
// ShowArray (newArray);
// Diff (newArray);
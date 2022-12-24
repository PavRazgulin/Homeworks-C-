// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// // 0, 7, 8, -2, -2 -> 2

// // 1, -7, 567, 89, 223-> 3

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

// int CountNumbers (int[]array)
// {
//     int count = 0;
//     for (int i=0; i<array.Lenght;i++);
//     {
//         if (i>0)
//         {
//            result=count++;
//         }
         
//     }
//     return result;
//     Console.WriteLine ($"Количество положительных чисел в массиве равно {result}");
// }


// Console.WriteLine("Введите размер массива");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение массива");
// int lenght = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(lenght,min,max);
// ShowArray (newArray);
// CountNumbers (newArray);

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 y = k2 * x + b2 значения b1, k1, b2 и k2 задаются пользователем.


// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

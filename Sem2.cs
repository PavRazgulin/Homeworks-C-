//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//Int SchowSec(int num)
//{
//int sot = num/10;
//return result= sot%10;
//}

//Console.WriteLine ("Введите число..");
//int a = Convert.ToIn32.(Console.ReadLine());
//int result = SchowSec(a);
//Console.Writeline(result);


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


//Console.Writeline("Введите число");
//int num = Convert.ToIn32.(Console.ReadLine());

//Void SchowThird(int num)
//{ 
    //if (num / 100 > 0)
    //{ 
      //  int result=Num/100%10; 
        //Console.WriteLine($"Это третья цифры числа {Num}");
    //}
    //else 
    //{
    //Console.WriteLine($"У числа {Num} третьей цифры нет");
    //}
//int result = SchowThird(num);
//Console.Writeline(result);
//}


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет



{
   int  Weekend (int num)
 {     
         if (num >5) 
         { 
           Console.WriteLine($"Этот день {num} - выходной!");
           return num;
         }
         else 
         {
           Console.WriteLine( $"Это обычный день {num}");
           return num;
         }
 }
 Console.WriteLine("Введите число   от 1 до 7");
// int DayWeek = new Random().Next (1,6+1); - как вариант
 int num = Convert.ToInt32(Console.ReadLine());
 Weekend(num);
}

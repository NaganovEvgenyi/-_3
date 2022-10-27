/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// (можно решить через строку, а можно математически)
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Строчный метод


Console.WriteLine("Введите пятизначное число:");
 string x = Console.ReadLine()!;
 if (x.Length == 5)
 {
     int a = Convert.ToInt32(x[0]);
     int b = Convert.ToInt32(x[1]);
     int c = Convert.ToInt32(x[3]);
     int d = Convert.ToInt32(x[4]);
    if ((a == d) && (b == c))
     {
         Console.WriteLine("Это число является палиндромом");
     }
     else
    {
         Console.WriteLine("Это число не является палиндромом");
     }

 }
 else
 {
     Console.WriteLine("Введите пятизначное число");
 } 

 //Математический метод

 Console.WriteLine("Введите пятизначное число:");
 int number = int.Parse(Console.ReadLine()!);
 int num1 = number / 10000;
 int num2 = number / 1000 % 10;
 int num3 = number / 100 % 10;
 int num4 = number / 10 % 10;
 int num5 = number % 10;
 if ((number >= 10000) && (number <= 99999))
 {
     if ((num1 == num5) && (num2 == num4))
     {
         Console.WriteLine("Ваше число является палиндромом");
     }
     else
     {
         Console.WriteLine("Ваше число не является палиндромом");
     }
 }
 else
 {
     Console.WriteLine("Введите пятизначное число!!!");
 }

 //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

 Console.WriteLine("Введите координату x первой точки:");
 int x1 = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату y первой точки:");
 int y1 = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату z первой точки:");
 int z1 = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату x второй точки:");
 int x2 = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату y второй точки:");
 int y2 = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите координату z второй точки:");
 int z2 = int.Parse(Console.ReadLine()!);

 double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
 Console.WriteLine($"Расстояние между точками {result}");*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int num1 = int.Parse(Console.ReadLine()!);
int i = 1;
int result = 0;
while (i <= num1){
    result = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine($"{result}");
    i++;
}

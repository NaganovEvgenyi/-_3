//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
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
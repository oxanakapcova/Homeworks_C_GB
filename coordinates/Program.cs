Console.Clear();
Console.WriteLine("Hello, Seminar 3!");
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double x1, x2, y1, y2, z1, z2 ;
System.Console.WriteLine("Write x1:");
x1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Write x2:");
x2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Write y1:");
y1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Write y2:");
y2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Write z1:");
z1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Write z2:");
z2 = double.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
//Math.Sqrt() =корень;Math.Pow(число, степень) = возведение в степень
System.Console.WriteLine("distance is: " + result);
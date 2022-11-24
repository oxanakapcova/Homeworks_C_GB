
// demo task
/*Console.Clear();

int n = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 10; // кол-во десятков
int n2 = n % 10; // кол-во единиц(последняя цифра числа)
if (n1 > n2)
    Console.Write(n1);
else
    Console.Write(n2);
    */
   /* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98


Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine($"random number: {n}");
int n1 = n / 100;
int n2 = n%10;
Console.Write(n1);
Console.Write(n2);//n1*10+3

12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

Console.Clear();

int n1 = new Random().Next();
int n2 = new Random().Next();

    if (n1 % n2 == 0)
Console.WriteLine("кратно");
    else
Console.WriteLine("не кратно, остаток" );


// task 12
Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0)
    Console.Write("yes");
else
    Console.Write($"не кратно, остаток {n % m}");

    14. Напишите программу, которая принимает на вход число и проверяет,
     кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да


// task 14
Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if ((n % 7) + (n % 23) == 0)
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.Clear();

Console.WriteLine("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m * m == n || n * n == m)
    Console.Write("yes");
else
    Console.Write("no");




Console.Clear();
/*
Задача 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int a;
a = 22;
int b;
b = 22;
int c;
c = 9;
if(a > b && a > c)
{
    Console.Write($"max number is {a}");
}
else if(b > a && b > c)
{
    Console.Write($"max number is {b}");
}
else if(c > a && c > b)
{
    Console.Write($"max number is {c}");
}
//тут программа не сработает если 2 числа будут больше третьего
//поэтому смотрим следующий файл с решением


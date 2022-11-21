/*
Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("please write your number: ");
int i = 1;
bool not = true;
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("even numbers from 1 to " + a);
while (i <= a)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("not even numbers");
}
//если вводимое число отрицательное программа напишет нет четных чисел
//я также не знаю как убрать последнюю запятую, был вариант просто с пробелом


﻿Console.Clear();
Console.WriteLine("Hello, Seminar 3!");
/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int value;
System.Console.WriteLine("Please, write your number: ");
value = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= value; i++)
System.Console.WriteLine($"{i*i*i}");

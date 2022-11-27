Console.Clear();
/*Задача 13: Напишите программу, которая выводит третью цифру(c начала) заданного числа
 или сообщает, что третьей цифры нет.
НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Please, write here your number: ");
int value = int.Parse(Console.ReadLine());
uint count = 0;
int currentValue = 0;

    if(value < 100 && value > -100)
Console.WriteLine("there is no third numeral!");//не уверенна в правильной англ грамматике
    else
{ 
    while(value > 99 || value < -99)
    {
    currentValue = value % 10;
    value = value / 10;
    }
    count++;
    System.Console.WriteLine("third numeral is: "+currentValue);
}// программа работает и с отрицательными числами
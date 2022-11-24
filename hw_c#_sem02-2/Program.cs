Console.Clear();
/*Задача 13: Напишите программу, которая выводит третью цифру(c начала) заданного числа
 или сообщает, что третьей цифры нет.
НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.WriteLine("Please, write here your number: ");
int a = Convert.ToInt32(Console.ReadLine());
    if(a < 100)
Console.WriteLine("there is no third numeral!");//не уверенна в правильной англ грамматике
    if (a > 99 && a < 1000)
{
int a3 = a % 10;//если число имеет 3 цифры работает, иначе находит последнюю цифру
Console.WriteLine(a3);
}

    if(a > 999)
{
int а4  = (a / 10)%10;
Console.WriteLine(a4);
}




Console.Clear();
Console.WriteLine("Hello Seminar 3!");
/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
System.Console.WriteLine("write 5numeral number: ");
int value = int.Parse(Console.ReadLine());
int fifthValue = value%10;
value = value/10;
int forthValue = value%10;
value = value/10;
int thirdValue = value%10;
value = value/10;
int secondValue = value%10;
value = value/10;
int firstValue = value%10;
value = value/10;
bool result = true;
result =firstValue-fifthValue==0 && secondValue-forthValue==0;
if (result == true)
System.Console.WriteLine("its palindrome number");
else
System.Console.WriteLine("it is not palindrome number");
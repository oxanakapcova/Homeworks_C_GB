// Currency exchange (hardcode)
Console.Clear();
string Currency;
int a;
double b;
Console.WriteLine("write how many rubles do You want to change: ");
Currency = Console.ReadLine();
a = int.Parse(Currency);
b = (double)a / 60;
System.Console.WriteLine(   "its " + b + " dollars");
//Урра получилось с первого раза!!!
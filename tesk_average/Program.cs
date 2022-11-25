// average среднее арифметическое 2 чисел
Console.Clear();
string number;
int a,b;
Console.WriteLine("Please, write 1th number: ");
number = Console.ReadLine();
a = int.Parse(number);
System.Console.WriteLine(   "Please, write 2nd number: ");
number = Console.ReadLine();
b = int.Parse(number);
double average = ((double)a + b)/2;
System.Console.WriteLine(   "Average is: "+ average);
//Ура работает с первого раза из головы!!!!
// average среднее арифметическое 2 чисел
Console.Clear();

int firstValue,secondValue;
Console.WriteLine("Please, write 1th number: ");
firstValue =int.Parse(Console.ReadLine());
System.Console.WriteLine(   "Please, write 2nd number: ");
secondValue = int.Parse(Console.ReadLine());

double average = ((double)firstValue + secondValue)/2;
System.Console.WriteLine(   "Average is: "+ average);
//Ура работает с первого раза из головы!!!!
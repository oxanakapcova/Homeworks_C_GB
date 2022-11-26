// calculator; use if ... else
System.Console.WriteLine(   "write 1th number: ");
double firstValue = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(   "+, -, / or * ");
char operand = Convert.ToChar(Console.ReadLine());

System.Console.WriteLine(   "write 2ns number: ");
double secondValue = Convert.ToDouble(Console.ReadLine());

if(operand == '+')
{
    double result = firstValue + secondValue;
    System.Console.WriteLine(   "Sum is "+ result);
}
else if(operand == '-')
{
    double result = firstValue - secondValue;
    System.Console.WriteLine(   "subtraction is "+ result);
}
else if(operand == '/')
{
    double result = firstValue / secondValue;
    System.Console.WriteLine(   "division is " + result);

}
else if(operand == '*')
{
    double result = firstValue * secondValue;
    System.Console.WriteLine(   "multiplication is " + result);

}
else
{
    System.Console.WriteLine(   "i dont know what You want, sorry. Try again!");
}
//Урра! с первого раза!!!
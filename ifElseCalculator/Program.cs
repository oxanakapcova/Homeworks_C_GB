// calculator; use if ... else

    Console.Clear();
System.Console.WriteLine(   "write 1th number: ");
double firstValue = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(   "+, -, / or * ");
char operand = Convert.ToChar(Console.ReadLine());

System.Console.WriteLine(   "write 2nd number: ");
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
    if(secondValue == 0)
        System.Console.WriteLine(   "Делить на 0 нельзя!");
    else
        System.Console.WriteLine(  "result is "+ firstValue / secondValue);

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
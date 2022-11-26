// подсчет четных и нечетных чисел в диапозоне указанным пользователем
//а также сумму четных и сумму нечетных
Console.Clear();
System.Console.WriteLine(   "write 1th number: ");
int currentValue = int.Parse(Console.ReadLine());
System.Console.WriteLine(   "write 2nd number: ");
int limit = int.Parse(Console.ReadLine());

uint evenCount = 0;
uint oddCount = 0;
int evenNumbersSum = 0;
int oddNumbersSum = 0;

while(currentValue <= limit)
{
    if(currentValue % 2 == 0)
    {
    evenCount++;
    evenNumbersSum +=currentValue;//evenNumbersSum + currentValue
    }
    else
    {
    oddNumbersSum += currentValue;
    oddCount++;
    }
    currentValue++;

}
System.Console.WriteLine("even numbers "+evenCount+"; odd numbers "+oddCount);
System.Console.WriteLine("sum even numbers is "+evenNumbersSum);
System.Console.WriteLine("sum odd numbers is "+oddNumbersSum);

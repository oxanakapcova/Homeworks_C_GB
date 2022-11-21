Console.Clear();
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Write number a, number b, number c:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine($"max is {max}");

/*я не уверена что это то что надо, но выдает макс число даже если они одинаковые (значит
все максимальные)
я только учусь
*/
            


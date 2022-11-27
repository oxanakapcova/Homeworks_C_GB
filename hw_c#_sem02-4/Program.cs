﻿
/*Второй максимум
Задана последовательность натуральных чисел, завершающаяся числом 0. 
Требуется определить значение второго по величине элемента в этой последовательности, 
то есть элемента, который будет наибольшим, если из последовательности удалить 
наибольший элемент.
Входные данные
Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел,
 не превышающих значения 100. Гарантируется, что во входных данных не более 100 чисел
  и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.
Выходные данные
В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума.
Примеры
№	INPUT.TXT	               OUTPUT.TXT
1	1 7 9 0	                    7
2	1 2 3 4 5 6 7 0 8 9 10	    6
*/
Console.Clear();

int value = Convert.ToInt32(Console.ReadLine());

int max = 0;
int secondMax = 0;
uint count = 0;
while(value != 0)
{
    value = Convert.ToInt32(Console.ReadLine());
    if(value > max)
    {
        secondMax = max; //0
        max = value;//1
        
    }
        else if (value > secondMax)
    {
        secondMax = value;    
    }
        count++;
        
}
Console.WriteLine("End");
System.Console.WriteLine(   "second max number is: "+secondMax);




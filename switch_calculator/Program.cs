//программа калькулятора с помощью switch (+. -, /, *)

System.Console.WriteLine(   "write 1th number: ");
double firstValue = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(   "введите оператор +, -, * или / ");
char symbol = Convert.ToChar(Console.ReadLine());

System.Console.WriteLine(   "write 2nd number: ");
double secondValue = Convert.ToDouble(Console.ReadLine());

switch  (symbol)
{
    case '+':
        System.Console.WriteLine(   "производится сложение ");
    double resultSum = firstValue + secondValue;
    System.Console.WriteLine(   "Sum is "+ resultSum);
        break;
    case '-':
        System.Console.WriteLine(   "производится вычитание ");
    double resultSub = firstValue - secondValue;
    System.Console.WriteLine(resultSub);
        break;
    case '*':
        System.Console.WriteLine(   "производится умножение ");
    double resultMult = firstValue * secondValue;
    System.Console.WriteLine(resultMult);
        break;
    case '/':
        System.Console.WriteLine(   "производится деление ");
    double resultDiv = firstValue / secondValue;
    System.Console.WriteLine(resultDiv);
        break;
    default:
        System.Console.WriteLine(   "введен неправильный символ, попробуйте еще раз ");
        break;
}
// не сразу разобралась с правильной последовательностью
//но сделала все сама, немного поэксперементировав
//Урааа!!!!
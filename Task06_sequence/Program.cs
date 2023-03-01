// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
int ReadInt(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void SequenseSumNumbers (int firstNumber, int secondNumber, int counter)
{
    if (counter>0)
    {
    Console.Write($"{firstNumber+secondNumber}\t");
    SequenseSumNumbers(secondNumber,firstNumber+secondNumber,counter-1);   
    }
}

int numberOne=ReadInt("Введите первое число: ");
int numberTwo=ReadInt("Введите второе число: ");
int count=ReadInt("Введите колличество чисел, которое нужно вывести без учета двух введенных: ");
Console.Write($"Последовательность чисел, для которых каждое следующее число равно сумме двух предыдущих: {numberOne}\t{numberTwo}\t");
SequenseSumNumbers(numberOne, numberTwo, count);
// Найти сумму элементов от M до N, N и M заданы
int ReadInt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int SumNumbersFromMtoN(int number1, int number2)
{
    if (number1==number2)
    return number2;
    else if (number1>number2)
    return number1+SumNumbersFromMtoN(number1-1, number2);
    else 
    return number1+SumNumbersFromMtoN(number1+1, number2);
}

int M=ReadInt("Введите число M:");
int N=ReadInt("Введите число N:");
Console.WriteLine();
Console.WriteLine($"Сумма элементов от {M} до {N} равна {SumNumbersFromMtoN(M, N)}");

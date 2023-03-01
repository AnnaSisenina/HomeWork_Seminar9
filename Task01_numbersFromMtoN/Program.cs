// Показать натуральные числа от M до N, N и M заданы
int ReadInt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void PrinNumbersFromMtoN(int number1, int number2)
{
    if (number1==number2)
    Console.WriteLine(number2);
    else if (number1>number2)
    {
        Console.WriteLine (number1);
        PrinNumbersFromMtoN(number1-1,number2);
        
    }
    else if (number1<number2)
    {
        Console.WriteLine (number1);
        PrinNumbersFromMtoN(number1+1,number2);
    }

}

int M=ReadInt("Введите число M:");
int N=ReadInt("Введите число N:");
Console.WriteLine();
PrinNumbersFromMtoN(M, N);
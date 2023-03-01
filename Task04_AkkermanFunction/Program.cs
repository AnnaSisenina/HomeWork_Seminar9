// Написать программу вычисления функции Аккермана
int ReadInt(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int AkkermanFunction (int m, int n)
{
    if (m==0)
    return n+1;
    else if(m>0&&n==0)
    return AkkermanFunction(m-1,1);
    else
    return AkkermanFunction(m-1, AkkermanFunction(m,n-1));
}

int numberOne=ReadInt("Введите первое число: ");
int numberTwo=ReadInt("Введите второе число: ");
Console.WriteLine($"Значение функции Аккермана для введенных чисел: {AkkermanFunction(numberOne, numberTwo)}");
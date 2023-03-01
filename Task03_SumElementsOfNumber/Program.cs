// Найти сумму цифр числа
int ReadInt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int SumElementsOfNumber (int number)
{
    if (number/10==0)
    return number;

    return SumElementsOfNumber(number/10)+number%10;

}

int inputNumber=ReadInt("Введите число:");
Console.WriteLine($"Сумма цифр введенного числа равна {SumElementsOfNumber(inputNumber)}");
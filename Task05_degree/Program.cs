// Написать программу возведения числа А в целую стень B
int ReadInt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int Involution (int number, int degree)
{
    if (degree==0)
    return 1;

    return number*Involution(number, degree-1);

}

int A=ReadInt("Введите число A:");
int B=ReadInt("Введите степень B, в которую необходимо возвести число:");
Console.WriteLine($"Число {A} в степени {B} равно {Involution(A,B)}");
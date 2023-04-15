// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Input()
{
    System.Console.WriteLine("Введи число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int a = Input();
int GetSumm(int a)
{
    int summ = 0;

    while(a!=0)
    {
        summ += a%10;
        a/=10;
    }
    return summ;
}

System.Console.WriteLine(GetSumm(a));
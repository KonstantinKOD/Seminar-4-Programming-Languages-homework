// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int EnterDigit(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int dig = int.Parse(input);
    return dig;
}

int num = EnterDigit("Введи основное число: ");
int degree = EnterDigit("Введи степень: ");

int Power(int num, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result = result * num;
    }
    return result;
}

bool ValidateEnter(int degree)
{
    if (degree < 0)
    {
        System.Console.WriteLine("Число не должно быть меньше ноля");
        return false;
    }
    return true;
}

if (ValidateEnter(degree))
{
    System.Console.WriteLine($"число {num} в степени {degree} равно {Power(num, degree)}");
}
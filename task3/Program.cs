// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int InputIndexesArray()
// {
//     System.Console.WriteLine("Введение чисел в массив");
//     int indexes = int.Parse(Console.ReadLine());
//     System.Console.WriteLine();
//     return indexes;
// }

int Inpulength(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}
int[] GenerateArray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= Inpulength("Индекс массива: ");
    }
    return array;
}
 void PrintArray(int[] array)
 {
    System.Console.WriteLine("----------Ваш массив----------");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
 }
int Length = Inpulength("Длинна массива: ");
System.Console.WriteLine();
int[] array = GenerateArray(Length);
PrintArray(array);
/// Написать программу, которая из имебщегося массива строк формирует массив, длина которых меньше либо равно 3 символа. 
/// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] ArrayStr = new string[] { };
Console.Write("Введите количество строк:");
int n = int.Parse(Console.ReadLine());
ArrayStr = new string[n];
for (int i = 0; i < ArrayStr.Length; i++)
{
    Console.Write($" Введите {i + 1} строку: ");
    ArrayStr[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Исходный массив :");

 for (int i= 0; i<ArrayStr.Length;i++)
    {
        Console.Write(ArrayStr[i]+" ");
    }

Console.WriteLine();

Console.Write("Введите предельную длинну элементов:");
int length = int.Parse(Console.ReadLine());
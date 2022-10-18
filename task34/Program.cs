/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.WriteLine("Введите размер массива ");
int size = int.Parse(Console.ReadLine());
int[] num = new int [size];
FillArrayRandomNumbers(num);
Console.WriteLine("массив ");
PrintArray(num);
int count = 0;

for (int g = 0; g < num.Length; g++)
{
    if (num[g] % 2 == 0)
    count++;
    {
        Console.WriteLine($"Всего {num.Length} чисел, {count} из них чётные");
    }
}

void FillArrayRandomNumbers(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
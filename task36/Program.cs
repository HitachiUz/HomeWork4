/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Введите размер массива ");
int size = int.Parse(Console.ReadLine());
int[] num = new int [size];
FillArrayRandomNumbers(num);
Console.WriteLine("массив ");
PrintArray(num);
int sum = 0;

for (int g = 0; g < num.Length; g+=2)
{
    sum = sum + num[g];

    Console.WriteLine($"всего {num.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");
}

void FillArrayRandomNumbers(int[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = new Random().Next(1,10);
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

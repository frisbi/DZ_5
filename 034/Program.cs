// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int GetEven(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

int[] Array = CreateRandomArray(6, 100, 999);
ShowArray(Array);
Console.WriteLine($"Количество четных элементов в массиве = {GetEven(Array)}");
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

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

int GetDifference(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (var item in array)
    {
       if (min > item) min = item;
       if (max < item) max = item; 
    }
    return max - min;
}

Console.Write("Введите колество элементов в массиве: ");
int S = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateRandomArray(S, 0, 999);
ShowArray(Array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {GetDifference(Array)}");
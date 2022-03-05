// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine();
Random rand = new Random();
int[,] FillArray()
{
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    int result = 0;
    int row = 1;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine($"Сумма строки {i + 1} = {sum}");
        if (i == 0)
        {
            result = sum;
        }
        else
        {
            if (sum < result)
            {
                result = sum;
                row = i + 1;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {row}");
}
int[,] doubleMass = FillArray();
Console.WriteLine("Задан двумерный массив :");
PrintArray(doubleMass);
SortArray(doubleMass);
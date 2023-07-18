// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет
//  -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void FindNumber(int[] array)
{
    int number = GetNum("Введите искомое число: ");
    bool flag = false;
    foreach (int el in array)
    {
        if (el == number) flag = true;
    }
    if (flag) Console.Write($"Число {number} присутствует в массиве");
    else Console.Write($"Число {number} отсутствует в массиве");
}

int arrSize = GetNum("Задайте размер массива: ");
int arrMin = GetNum("Введите минимальное значение массива: ");
int arrMax = GetNum("Введите максимальное значение массива: ");

int[] arr = GetArray(arrSize, arrMin, arrMax);

PrintArray(arr);

FindNumber(arr);
/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int getIntFromUser(string message)  
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}

int [] FillArrayRandomNumbers(int length, int start, int end)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start,end);
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
   
    if (i != array.Length -1)
    {
        Console.Write($"{array[i]},");
    }
    else
    {
        Console.Write($"{array[i]}]");
    }
    Console.WriteLine();
}
int size = getIntFromUser ("Введите размер массива");
int[] arr = FillArrayRandomNumbers(size,1,100);
Console.WriteLine("Получен массив: ");
PrintArray(arr);
int maxFillarray = arr[0];
int minFillarray = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > maxFillarray)
    {
        maxFillarray = arr[i];
    }
    if (arr[i] < minFillarray)
    {
        minFillarray = arr[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");

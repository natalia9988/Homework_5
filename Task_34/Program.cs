/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int getIntFromUser(string message)  
{
    Console.Write(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}

void FillArrayRandomNumbers(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
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


Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] arr = new int[size];
FillArrayRandomNumbers(arr);
Console.WriteLine("Получен массив: ");
PrintArray(arr);
int count = 0;

for (int i = 0; i < arr.Length; i++)
if (arr[i] % 2 == 0)
count++;

Console.WriteLine($"Всего получено {arr.Length} чисел, {count} из них чётные");
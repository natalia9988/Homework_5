/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
int sum = 0;

for (int i = 0; i < arr.Length; i+=2)
    sum = sum + arr[i];



Console.WriteLine($"Сумма элементов нечетных позиций = {sum}");

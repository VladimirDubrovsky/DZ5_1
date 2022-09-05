//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] collection)
{ 
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i]=new Random().Next(100, 999);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.WriteLine(col[i]);
    }
}

int count = new Random().Next(1, 40);
int[] array = new int[count];

FillArray(array);
PrintArray(array);

int number=0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        number++;
    }
}

Console.WriteLine($"Колличество элементов в массиве: {count} , из них четных чисел в массиве: {number}");
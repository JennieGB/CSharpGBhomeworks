/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве. [345, 897, 568, 234] -> 2 */

void fillArray(int[] array) // Заполнение массива
{
    for (int count = 0; count < array.Length; count++)
    {
        array[count] = new Random().Next(100, 1000);
    }
}

void printArray(int[] array) // Печать чётных чисел массива
{
    for (int count = 0; count < array.Length; count++)
    {
        if (array[count] % 2 == 0)
        {
            Console.Write($"{array[count]} ");
        }
    }
    Console.WriteLine();
}

Console.Write("Задайте длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[num];

fillArray(newArray);
Console.Write("Чётные числа в массиве: ");
printArray(newArray);
Console.WriteLine();


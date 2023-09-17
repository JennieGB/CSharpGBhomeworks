/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void fillArray(int[] array) // Заполнение массива
{
    for (int count = 0; count < array.Length; count++)
    {
        array[count] = new Random().Next(-999999, 1000000);
    }
}

void printArray(int[] array) // Печать чисел массива, стоящих на нечётных позициях
{
    int sum = 0;
    for (int count = 0; count < array.Length; count++)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{array[count]}, ");
            sum = sum + array[count];
        }
    }
    Console.WriteLine($"Сумма этих чисел равна: {sum}");
}

Console.Write("Задайте длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[num];

fillArray(newArray);
Console.Write("Числа в массиве, стоящие на нечётных позициях: ");
printArray(newArray);
Console.WriteLine();

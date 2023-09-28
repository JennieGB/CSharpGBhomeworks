/* Задача 4. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int count = 729;
int[,,] createThreeDimensionalArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[count];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;
    for (int i = 0; i < values.Length; i++)
    {
        int indexRandom = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[indexRandom];
        values[indexRandom] = temp;
    }
    int indexValue = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[indexValue++];
            }
        }
    }
    return array;
}
Console.WriteLine("Трехмерный массив имеет три величины, необходимо их задать.");
int firstValue = InputInt("Введите первую величину: ");
int secondValue = InputInt("Введите вторую величину: ");
int thirdValue = InputInt("Введите третью величину: ");
if (firstValue * secondValue * thirdValue > count)
{
    Console.Write("Массив с заданными параметрами имеет слишком большой размер! ");
    return;
}
int[,,] resultNums = createThreeDimensionalArray(firstValue, secondValue, thirdValue);
for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"Координаты элемента {resultNums[i, j, k]}: ({i},{j},{k})");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

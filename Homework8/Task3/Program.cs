/* Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
void CreateArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            array[countOne, countTwo] = new Random().Next(-100, 101);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            Console.Write(array[countOne, countTwo] + " ");
        }
        Console.WriteLine("");
    }
}
Console.Write("Введите размер матрицы: ");
int size = int.Parse(Console.ReadLine());
int[,] firstMatrix = new int[size, size];
int[,] secondMatrix = new int[size, size];
CreateArray(firstMatrix);
CreateArray(secondMatrix);
int[,] matrixMultiplication = new int[size, size];
for (int a = 0; a < size; a++)
{
    for (int b = 0; b < size; b++)
    {
        for (int c = 0; c < size; c++)
        {
            matrixMultiplication[a, b] = matrixMultiplication[a, b] + (firstMatrix[a, c] * secondMatrix[c, b]);
        }
    }
}
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);
Console.WriteLine("Произведение заданных матриц:");
PrintArray(matrixMultiplication);


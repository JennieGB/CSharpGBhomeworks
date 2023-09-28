/* Задача 5. Напишите программу, которая заполнит спирально прямоугольный массив.
Например, на выходе может получиться вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void CreateSpiralArray(int[,] array)
{
    int count = new Random().Next(1, 100);
    for (int horizontNum = 0; horizontNum < array.GetLength(0); horizontNum++)
    {
        for (int verticalNum = 0; verticalNum < array.GetLength(0); verticalNum++)
        {
            if (horizontNum == 0) { array[horizontNum, verticalNum] = count; count++; }
            if (horizontNum == 1 & verticalNum < 3) { array[horizontNum, verticalNum] = count + 7; count++; }
            if (horizontNum == 1 & verticalNum == 3) { array[horizontNum, verticalNum] = count - 3; }
            if (horizontNum == 2 & verticalNum == 0) { array[horizontNum, verticalNum] = count + 3; }
            if (horizontNum == 2 & verticalNum > 0 & verticalNum < 3) { array[horizontNum, verticalNum] = count + 8; count--; }
            if (horizontNum == 2 & verticalNum == 3) { array[horizontNum, verticalNum] = count; }
            if (horizontNum == 3 & verticalNum <= 4) { array[horizontNum, verticalNum] = count + 4; count--; }
            Console.Write($"{array[horizontNum, verticalNum]} ");
        }
        Console.WriteLine();
    }
}
int[,] array = new int[4, 4];
CreateSpiralArray(array);

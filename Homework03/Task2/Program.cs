/* Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты 
двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координату x первой точки ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки ");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние между указанными точками равно {Math.Round(Convert.ToDouble(Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb))), 2)} ");

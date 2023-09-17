
int a = Convert.ToInt32(Console.ReadLine());
if ((a > 99999) || (a < 10000))
{
    Console.WriteLine($"Вы ввели не пятизначное число {a}, магии не будет!");
    return;
}
string str = Convert.ToString(a);
int[] array = new int[str.Length];
int i;
for (i = 0; i < str.Length; i++) { array[i] = Convert.ToInt32(str[i].ToString()); }
// Console.Write(array[i] + " ");
if ((array[0] == array[4]) && (array[1] == array[3]))
{
    Console.WriteLine($"{a} - это точно палиндром!");
}
else { Console.WriteLine($"{a} не палиндром, число не зеркально"); }
Console.WriteLine("Всего доброго! Буду рад пообщаться снова! ");

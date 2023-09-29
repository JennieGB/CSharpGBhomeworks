int AckermannFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
        return secondNumber + 1;
    else if (firstNumber > 0 && secondNumber == 0)
        return AckermannFunction(firstNumber - 1, 1);
    else
        return AckermannFunction(firstNumber - 1, AckermannFunction(firstNumber, secondNumber - 1));
}


Console.Write("Введите первое число (m): ");
int firstSuperNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число (n): ");
int secondSuperNumber = Convert.ToInt32(Console.ReadLine());

int ackermannResult = AckermannFunction(firstSuperNumber, secondSuperNumber);

Console.WriteLine($"Aккерман фанкшн ({firstSuperNumber},{secondSuperNumber}) = {ackermannResult}");

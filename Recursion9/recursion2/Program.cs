int GetSumOfRange(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
        return GetSumOfRange(firstNumber, secondNumber + 1) + secondNumber;

    else if (secondNumber > firstNumber)
        return GetSumOfRange(firstNumber + 1, secondNumber) + firstNumber;

    else
        return firstNumber;
}

Console.Write("Введите первое число промежутка: ");
int firstSuperNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число промежутка: ");
int secondSuperNumber = Convert.ToInt32(Console.ReadLine());

int sumOfRange = GetSumOfRange(firstSuperNumber, secondSuperNumber);

Console.WriteLine($"Сумма [{firstSuperNumber}, {secondSuperNumber}]: {sumOfRange}");

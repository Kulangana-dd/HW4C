/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

int SumOfDigits (int userNumber)
{
    int result = 0;
    while (userNumber > 0)
    {
        result = result + userNumber % 10;
        userNumber = userNumber / 10;
    }
    return result;
}

Console.Write("Введите целое положительное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int sumOfDigits = SumOfDigits(userNumber);
Console.WriteLine($"Сумма цифр числа {userNumber} равна {sumOfDigits}");
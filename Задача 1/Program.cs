/*
Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число:");

int number = Convert.ToInt32(Console.ReadLine( ));

int Length = number.ToString().Length;

if (Length < 3 || Length > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int getTwoDigitFromNumber (int number)

{
    int secondDigit = ((number / 10) % 10);
    return secondDigit;
}

int secondDigit = getTwoDigitFromNumber (number);
Console.WriteLine($"Второй цифрой числа {number} является {secondDigit}");
}


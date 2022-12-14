/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int result = GetSum(num);
Console.WriteLine($"Сумма цифр числа {num} равняется: {result}");

int GetSum(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10; // % (знак деления с остатком) делит число на 10 но получает значение только остатка. к примеру 452 % 10 = 2.
        a = a / 10; //(просто деление) к примеру 452 / 10 = 45 или 4 / 10 = 0.
    }
    return sum;
}

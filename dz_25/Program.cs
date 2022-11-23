/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

//создаём переменную А и Б и вкладывает в нее значение введенное с консоли
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = GetDegree(a, b);
Console.WriteLine($"Число {a} в натуральной степени {b} равняется: {result}");


int GetDegree(int a, int b)
{
    int degree = a;
    for(int i = 1; i < b; i++)
    {
         degree = degree * a;
    }
    return degree;
}

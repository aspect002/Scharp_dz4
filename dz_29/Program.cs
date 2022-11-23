/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33  -> [1, 2, 5, 7, 19,6, 1, 33] */

Console.Write("Введите длинну массива: ");
int lengthMass = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArray(lengthMass);
PrintArray(arr);






int[] FillArray(int length)
{
    int[] result = new int[length]; //создаём массив с именем ресалт и присваиваем ему пустой массив с длинной length

   //1 действие     2 условие        3 действие
    for(int i = 0; i < result.Length; i++) //сначало выполняется действие 1
    {   //после проверка условия, если оно верно, то проваливаемся в тело цикла
        Console.Write($"введите {i} элемент массива: ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    } //после выполнения кода, происходит 3 действие плюсуется счётчик, и после снова возвращаемся к первому действию где i уже равен +1
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write($"ваш массив: ");

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

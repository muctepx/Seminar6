/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/

Console.Clear();
Console.WriteLine("Введите числа через запятую или пробел: ");
string[] separatingStrings = { ", ", "  ", ",", " " };
int[] arr = Array.ConvertAll(Console.ReadLine().Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.Write($"Кол-во чисел больше 0: {count}");
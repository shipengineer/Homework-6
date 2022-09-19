﻿//----------------------------------Exercise #41------------------------------
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
//----------------------------------SOLUTION-----------------------------------


System.Console.WriteLine("Введите числа через пробел");
            //       1              2              3               4
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
/*
1 -- считываем с консоли запись в формате string;
2 -- разделяем ввод посредством используя разделитель "пробел";
3 -- используем метод проекции каждого разделенного элемента из string в int;
4 -- превращаем полученный список в массив;
*/

 int count(int[] mas)
 {
    int i = 0;
    foreach (var item in mas)
    {
        if(item > 0 ) i++;
    }
    return i;
 }
System.Console.WriteLine($"В массиве {String.Join("|", array)} элементов больше нуля: {count(array)}");

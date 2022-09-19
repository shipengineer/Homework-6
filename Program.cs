//----------------------------------Exercise #41------------------------------
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
//----------------------------------SOLUTION-----------------------------------

/*
System.Console.WriteLine("Введите числа через пробел");
            //       1              2              3               4
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
/*
1 -- считываем с консоли запись в формате string;
2 -- разделяем ввод посредством используя разделитель "пробел";
3 -- используем метод проекции каждого разделенного элемента из string в int;
4 -- превращаем полученный список в массив;
*/
/*
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
*/
//----------------------------------Exercise #41------------------------------
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
//----------------------------------SOLUTION-----------------------------------

double[] crossPt(double k1, double k2, double b1, double b2)
{
    double[] result = new double[2];
   result[0] = (b1 - b2)/(k2-k1); // Вычисляем Х
   result[1] = k1*result[0] + b1;      // Вычисляем Y
    // double y2 = k2*x +b2;
   return result;

}
System.Console.Write(" введите коэфициент k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите коэфициент b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите коэфициент k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите коэфициент b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
double[] answer = crossPt(k1,k2,b1,b2);
System.Console.WriteLine($"Точка пересечения заданных линейных уравнений Х = {answer[0]},  Y = {answer[1]}");
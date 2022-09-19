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
/*
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
*/
//----------------------------------Exercise #41------------------------------
/*
задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.*/
//----------------------------------SOLUTION-----------------------------------
object[] Triangle(double a, double b, double c)
{
    // Проверка на наличие треугольника
    object[] result = new object[10];
    if (a + b > c && c + b > a && a + c > b) result[0] = $"Такой треугольник существует его стороны а = {a}, b = {b}, c = {c} ";
    else
    {
        Array.Resize(ref result, 1);
        result[0] = $"Такой треугольник НЕ существует, дружок";
        return result;
    }
    // Вычисление углов 
    int alpha = Math.Round(Math.Acos((a * a + b * b - c * c) / (2 * a * b)));
    int betta = Math.Round(Math.Acos((c * c + b * b - a * a) / (2 * c * b)));
    int gamma = 180 - result[1] - result[2];
    // Проверка прямоугольного треугольника
    if (alpha == 90 || betta == 90 || gamma == 90) result[4] = "Это прямоугольный треугольник";
    else result[4] = "Треугольник не прямоугольный";
    if (alpha == betta || alpha == gamma || gamma == betta) result[5] = "Треугольник равнобедренный";
    else result[5] = "Треугольник не равнобедренный";


    return result;

}
System.Console.Write(" введите сторону a ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите сторону b ");
double b = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите сторону c ");
double c = Convert.ToDouble(Console.ReadLine());

object[] arr = Triangle(a, b, c);
System.Console.WriteLine(String.Join("|", arr));
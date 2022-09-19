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
int[] resultay = Console.ReadLine().Split().Select(int.Parse).ToArray();
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
System.Console.WriteLine($"В массиве {String.Join("|", resultay)} элементов больше нуля: {count(resultay)}");
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
void Triangle(double a, double b, double c)
{
    // Проверка на наличие треугольника
    string[] result = new string[9];
    if (a + b > c && c + b > a && a + c > b) result[0] = $"Такой треугольник существует его стороны а = {a}, b = {b}, c = {c} ";
    else
    {
        System.Console.WriteLine("Такой треугольник НЕ существует, дружок"); ;
        return;
    }
    // Вычисление углов 
    int alpha = Convert.ToInt32(Math.Round(180 * Math.Acos((a * a + b * b - c * c) / (2 * a * b)) / Math.PI));
    int betta = Convert.ToInt32(Math.Round(180 * Math.Acos((c * c + b * b - a * a) / (2 * c * b)) / Math.PI));
    int gamma = 180 - alpha - betta;
    result[1] = Convert.ToString(alpha);
    result[2] = Convert.ToString(betta);
    result[3] = Convert.ToString(gamma);
    // Проверка прямоугольного треугольника
    if (alpha == 90 || betta == 90 || gamma == 90) result[4] = "";
    else result[4] = "не ";
    // Проверка равнобедренности треугольника
    if (alpha == betta || alpha == gamma || gamma == betta) result[5] = "";
    else result[5] = "не ";
    // Проверка на равносторонность
    if (alpha == betta && alpha == gamma) result[6] = "";
    else result[6] = "не ";
    // Вычисление площади треугольника
    result[7] = Convert.ToString(Math.Round(a * b * Math.Sin(alpha) / 2, 4));
    // Вычисление периметра
    result[8] = Convert.ToString(a + b + c);
    System.Console.WriteLine("------------------------------------------------------------------------------------");
    System.Console.WriteLine($"{result[0]}");
    System.Console.WriteLine($"Он {result[4]}прямоугольный, {result[5]}равнобедренный, {result[6]}равносторонний");
    System.Console.WriteLine($"С площадью {result[7]} m^2 и периметром {result[8]} m");

}

void loading(char ask)
{
    System.Console.WriteLine("");
}
System.Console.Write(" введите сторону a ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите сторону b ");
double b = Convert.ToDouble(Console.ReadLine());
System.Console.Write(" введите сторону c ");
double c = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Запустить сбор статистики о введеном треугольнике?");
char ask = Console.ReadKey().KeyChar;

Triangle(a, b, c);



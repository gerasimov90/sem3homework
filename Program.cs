/* Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.


Console.Write("Введите любое пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000 && number >= 10000)
{
    int firstnumb = number / 10000;

    int secondnumb = (number - firstnumb*10000)/1000;

    int lastnumb = number % 10;

    int prelastnumb = (number % 100)/10;

    if (firstnumb == lastnumb && secondnumb == prelastnumb)
    {
        Console.Write("Введенное число - палиндром");
    }
    else Console.Write("Введенное число не является палиндромом");

}
else Console.WriteLine("Неверный ввод числа. ");
*/

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
*/
Console.Write("Введите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine("Расстояние между 2 точками: " + Math.Round(d,2));





/* Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
*/

Console.Write("Введите любое пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000 && number >= 10000)
{
    int firstnumb = number / 10000;

    int secondnumb = (number - firstnumb*1000)/1000;

    int lastnumb = number % 10;

    int prelastnumb = (number % 100)/10;

    if (firstnumb == lastnumb && secondnumb == prelastnumb)
    {
        Console.Write("Введенное число - палиндром");
    }
    else Console.Write("Введенное число не является палиндромом");

}
else Console.WriteLine("Неверный ввод числа. ");
    



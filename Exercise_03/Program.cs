/*
Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

using System.ComponentModel.DataAnnotations;
using System.Globalization;

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int first = num / 10;
int second = num % 10;

if (num > 9 && num < 100)
{

}
else
{
    System.Console.WriteLine("Не верное число!");
}
if (first > second)
{
    System.Console.WriteLine(first);
}
else
System.Console.WriteLine(second);


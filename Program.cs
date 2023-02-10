/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/


Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int conver = a;

for (int i = 1; i < b; i++)
{
conver = conver * a;
}
Console.WriteLine($"{a}, {b} = {conver} ");

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/


Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int number = i % 10;
i = i / 10;
sum = sum + number;
}
Console.WriteLine($"сумма = {sum} ");

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

int [] numbers = new int[8];

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 21);
    Console.Write($" {Method (i)} ");
 }

int Method (int a)
{
    return numbers[a];
}



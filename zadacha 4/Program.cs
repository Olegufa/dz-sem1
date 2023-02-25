//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Ведите первое число: ");
int namber1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе число: ");
int namber2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите третее число: ");
int namber3 = Convert.ToInt32(Console.ReadLine());

int Max = namber1;

if (namber1 > Max)
{
    Max = namber1;
}
if (namber2 > Max)
{
    Max = namber2;
}
if (namber3 > Max)
{
    Max = namber3;
}
Console.Write ($"Max {Max}");
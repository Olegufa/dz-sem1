// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Ведите первое число: ");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int namber2 = Convert.ToInt32(Console.ReadLine());

if ( namber1 < namber2 ) 
{
    Console.Write($"Min {namber1} Max {namber2}");
}
else
{
    Console.Write ($"Max {namber1} Min {namber2}");
}


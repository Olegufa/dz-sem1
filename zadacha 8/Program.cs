



//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.


Console.Write("Ведите первое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 1;


while (temp <= N)
 {
     if (temp%2 == 0)
          {
               Console.Write($"{temp} ");
          }

     temp++;
}



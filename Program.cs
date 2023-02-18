/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


int max = 0;
int min = 0;

Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num1;
    min = num2;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


int max = 0;

Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > max)
{
    max = num1;
}
if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}

Console.WriteLine("max = " + max);

*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет



Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}

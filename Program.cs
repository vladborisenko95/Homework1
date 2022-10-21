// /* 
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// */

Console.WriteLine("Введите два целых числа ");
int number1 = Convert.ToInt32( Console.ReadLine());
int number2 = Convert.ToInt32( Console.ReadLine());
int max = 0;
int min = 0;

if( number1 > number2 ) 
{
    max = number1;
    min = number2;
    Console.WriteLine("Максималное число - " + max + "," + " Минимальное число - " + min);
}
else if ( number1 == number2) 
{
    Console.WriteLine("Введенные Вами числа равны");
}
else 
{
    max = number2;
    min = number1;
    Console.WriteLine("Максималное число - " + max + "," + " Минимальное число - " + min);
}


// /*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// */

Console.WriteLine("Введите три целых числа ");
int number1 = Convert.ToInt32( Console.ReadLine());
int number2 = Convert.ToInt32( Console.ReadLine());
int number3 = Convert.ToInt32( Console.ReadLine());
int max = 0;

if (number1 > number2)
{
    max = number1;
}
else if ( number2 > number3 )
{
    max = number2;
}
else 
{
    max = number3;
}

Console.WriteLine("Максималное число - " + max);

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32( Console.ReadLine());

if ( number1 % 2 == 0) 
{
    Console.WriteLine("Число четное " + number1);
}
else 
{
    Console.WriteLine("Число нечетное " + number1);
}


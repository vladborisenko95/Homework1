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
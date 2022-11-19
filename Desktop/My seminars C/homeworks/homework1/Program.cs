/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

 /* Задача 2
 Console.WriteLine("Input number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Imput number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
           
            if(num1 > num2)
            {
            max = num1
            min = num2
            }
            else 
            {
                   max = num2;
                  min = num1;
            }
            else
            {
                Console.WriteLine("max = " + max + " и " + "min = " + min);
            }*/

/*Задача 4
Console.WriteLine("Input a");
            int  a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Imput b");
            int b  = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Imput  c");
            int c =  Convert.ToInt32(Console.ReadLine());
            
            int max = a;

            if (a > max) max = a;
            if (b > max) max = b;
            if (c> max) max = c;
            Console.Write("max =");
            Console.WriteLine(max);*/

/*Задача 6
Console.WriteLine("Imput number");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine(" Yes");

}
else
{
    Console.WriteLine( "No");
}*/

/* Хадача 8
Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}/*








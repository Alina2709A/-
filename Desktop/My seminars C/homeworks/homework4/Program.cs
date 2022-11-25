/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}

  Console.Write("Imput number A ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Imput number B");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Answer " + exponentiation);*/

  /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*Console.Write("Imput number");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int number)
  {
    
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = number- number % 10;
      result = result + (number- advance);
      number = number / 10;
    }
   return result;
  }
int sumNumber = SumNumber(number);
Console.WriteLine("The sum of digits in number" + sumNumber);*/

/*Задача 29
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

/*Console.Write("Imput series of numbers");
int size = 8;
            int[] array = new int[8];
            Random myRandom = new Random();
 
            Console.WriteLine("Вывод с помощью for");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 100);
                Console.Write("{0} ", array[i]);
            }*/
 
        

﻿/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
	
	3, 5 -> 243 (3⁵)
	
	2, 4 -> 16
	*/
	

	int Exponentiation(int num1, int num2)
	{
	    int result = 1;
	    for (int i = 1; i <= num2; i++)
	    {
	        result = result * num1;
	    }
	    return result;
	}
	

	Console.Write("Введите число А: ");
	int num1 = Convert.ToInt32(Console.ReadLine());
	Console.Write("Введите число B: ");
	int num2 = Convert.ToInt32(Console.ReadLine());
	

	int exponentiation = Exponentiation(num1, num2);
	Console.WriteLine("Результат: " + exponentiation);


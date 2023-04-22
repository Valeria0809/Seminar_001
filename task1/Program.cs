//Напишите программу, которая на вход принимает число 
//и выдает его квадрат (умноженное само на себя)/
//Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Квадрат заданного числа равен " + sqr);
System.Console.WriteLine($"Квадрат заданного числа равен: {sqr}");
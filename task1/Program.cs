// Напишите программу, котрая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Например:
// а=25, b=5 -> Да
// а=2, b=10 -> Нет
// а=9, b= -3 -> Да
// а= -3, b=9 -> Нет
Console.WriteLine("Введите первое число");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int numberTwo = int.Parse(Console.ReadLine());
if ( numberOne == numberTwo*numberTwo)
{
    Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");  
}
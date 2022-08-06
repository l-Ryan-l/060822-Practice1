//Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5, b = 25 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> нет 
// a = -3, b = 9 -> да

Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA == Math.Sqrt(numberB))
{
    Console.Write("Да!");
}
else
{
    Console.Write("Нет!");
} 
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = numberOne;
if(max < numberTwo) {
  max = numberTwo;
}
if(max < numberThree) {
  max = numberThree;
}
Console.WriteLine($"max = {max}");
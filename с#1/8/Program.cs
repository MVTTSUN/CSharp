// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
if(number >= 1) {
  while(i <= number) {
    if(i % 2 == 0) {
      Console.Write($"{i} ");
    }
    i++;
  }
}
else {
  Console.WriteLine("Число должно быть больше либо равно 1");
}
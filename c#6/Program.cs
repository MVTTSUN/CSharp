void Task41() {
  Console.WriteLine("Введите числа:");
  int cnt = 0;
  for(int i = 0;;i++) {
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) {
      cnt++;
    }
    Console.WriteLine($"Кол-во введенных элементов больше нуля: {cnt}");
  }
}

Task41();

void Task43(double b1, double k1, double b2, double k2) {
  if(b1 == b2 && k1 == k2) {
    Console.WriteLine($"Функции одинаковые");
  } else if(k1 == k2) {
    Console.WriteLine($"Функции параллельны");
  } else {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Функции перескаются в точках x: {x}, y: {y}");
  }
}

Task43(2, 5, 4, 9);
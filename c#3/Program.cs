void Task19(int number) {
  string str = Convert.ToString(number);
  if (str.Length == 5) {
    if(str[0] == str[4] && str[1] == str[3]) {
      Console.WriteLine("Является палиндромом");
    } else {
      Console.WriteLine("Не является палиндромом");
    }
  } else {
    Console.WriteLine("Число не пятизначное");
  }
}

Task19(12821);

void Task21(int x1, int y1, int z1, int x2, int y2, int z2) {
  Console.WriteLine($"Расстояние: {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))}");
}

Task21(7, -5, 0, 1, -1, 9);

void Task23(int N) {
  if(N >= 1) {
    for(int i = 1; i <= N; i++) {
      Console.Write($"{Math.Pow(i, 3)} ");
    }
  } else {
    Console.Write("Значение должно от единицы");
  }
}

Task23(5);
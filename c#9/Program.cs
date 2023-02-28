//64
int PrintNumbers(int m, int n) {
  if(m != n) {
    Console.Write($"{m} ");
    return m + PrintNumbers(m + 1, n);
  } else {
    Console.Write($"{m} ");
    Console.WriteLine();
    return m;
  }
}

PrintNumbers(4, 8);

//66
int SumNumbers(int m, int n) {
  if(m != n) {
    return m + SumNumbers(m + 1, n);
  } else return m;
}

Console.WriteLine(SumNumbers(1, 15));

//68
int Akkerman(int m, int n) {
  if(m == 0) {
    return n + 1;
  } else if(m > 0 && n == 0) {
    return Akkerman(m - 1, 1);
  } else if(m > 0 && n > 0) {
    return Akkerman(m - 1, Akkerman(m, n - 1));
  } else return 0;
}

Console.WriteLine(Akkerman(3, 2));
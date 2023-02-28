void PrintArrayDouble(double[,] arr) {
  for(int i = 0; i < arr.GetLength(0); i++) {
    for(int j = 0; j < arr.GetLength(1); j++) {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
}

void PrintArrayInt(int[,] arr) {
  for(int i = 0; i < arr.GetLength(0); i++) {
    for(int j = 0; j < arr.GetLength(1); j++) {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] Array(int m, int n) {
  int[,] arr = new int[m, n];
  for(int i = 0; i < arr.GetLength(0); i++) {
    for(int j = 0; j < arr.GetLength(1); j++) {
      arr[i, j] = new Random().Next(0, 10);
    }
  }
  return arr;
}

//47
double[,] RandomArrayDouble(int m, int n) {
  double[,] arr = new double[m, n];
  for(int i = 0; i < arr.GetLength(0); i++) {
    for(int j = 0; j < arr.GetLength(1); j++) {
      arr[i, j] = new Random().Next(-9, 10) + Math.Round(new Random().NextDouble(), 1);
    }
  }
  return arr;
}

PrintArrayDouble(RandomArrayDouble(3, 4));

//50
void FindElement(int m, int n, int[,] arr) {
  if(m > arr.GetLength(1) - 1 || n > arr.GetLength(0) - 1) {
    Console.WriteLine("Такое числа в массиве нет");
  } else {
    Console.WriteLine("Такое число в массиве есть");
  }
  Console.WriteLine(arr.GetLength(1));
}

FindElement(2, 3, Array(3, 4));

//52
void AverageColumns(int[,] arr) {
  double[] lineArray = new double[arr.GetLength(1)];
  for(int i = 0; i < arr.GetLength(1); i++) {
    double sum = 0;
    for(int j = 0; j < arr.GetLength(0); j++) {
      sum += arr[j, i];
    }
    lineArray[i] = Math.Round(sum / arr.GetLength(0), 1);
  }
  Console.WriteLine();
  Console.WriteLine(String.Join(" ", lineArray));
}

int[,] arr = Array(3, 4);
PrintArrayInt(arr);
AverageColumns(arr);
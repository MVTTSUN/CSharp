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

int[,] arr = Array(5, 4);
PrintArrayInt(arr);

//54
int[,] SortArrayRowDecrease(int[,] arr) {
  int lenRow = arr.GetLength(0);
  int lenCol = arr.GetLength(1);
  int tmp;
  for(int row = 0; row < lenRow; row++) {
    for(int col = 0; col < lenCol; col++) {
      for (int i = col + 1; i < lenCol; i++) {
        if (arr[row, col] > arr[row, i])
        {
          tmp = arr[row, col];
          arr[row, col] = arr[row, i];
          arr[row, i] = tmp;
        }
      }
    }
  }
  return arr;
}

Console.WriteLine();
PrintArrayInt(SortArrayRowDecrease(arr));

//56
void FindMinRow(int[,] arr) {
  int lenRow = arr.GetLength(0);
  int lenCol = arr.GetLength(1);
  int[] arrRowsAverage = new int[lenRow];
  for(int i = 0; i < lenRow; i++) {
    int sum = 0;
    for(int j = 0; j < lenCol; j++) {
      sum += arr[i, j];
    }
    arrRowsAverage[i] = sum;
  }
  int min = arrRowsAverage[0];
  int indexMin = 0;
  for(int i = 0; i < arrRowsAverage.Length; i++) {
    if(min > arrRowsAverage[i]) indexMin = i;
  }
  Console.WriteLine($"Строка с наименьшей суммой элементов: {indexMin + 1}");
}

FindMinRow(arr);

//58
Console.WriteLine();
int[,] arr2 = Array(4, 5);
PrintArrayInt(arr2);

void MatrixMult(int[,] arr1, int[,] arr2) {
  int lenRow = arr1.GetLength(0);
  int lenCol = arr1.GetLength(1);
  if(lenRow == arr2.GetLength(1))  {
    int size = 0;
    if(lenRow > lenCol) {
      size = lenRow;
    } else size = lenCol;
    int[,] arr = new int[size, size];
    for(int i = 0; i < lenRow; i++) {
      for(int j = 0; j < arr2.GetLength(1); j++) {
        for (int k = 0; k < arr2.GetLength(0); k++) {
          arr[i,j] += arr1[i,k] * arr2[k,j];
        }
      }
    }
    Console.WriteLine();
    PrintArrayInt(arr);
  } else {
    Console.WriteLine("Введите матрицы, у которых столбцы одной совпадает со строкой другой");
  }
}

MatrixMult(arr, arr2);

//60
int[] RandomNonRecurNumbers(int x, int y, int z) {
  int len = x * y * z;
  int[] randArr = new int[len];
  Random rand = new Random();
  randArr[0] = rand.Next(10, 100);
  for (int i = 1; i < len;) {
    int num = rand.Next(10, 100);
    int j;
    for (j = 0; j < i; j++) {
      if (num == randArr[j]) break;
    }
    if (j == i)
    {
      randArr[i] = num;
      i++;
    }
  }
  return randArr;
}

void CubeArray(int x, int y, int z) {
  int[,,] arr = new int[x, y, z];
  Random rand = new Random((int)DateTime.Now.Ticks);
  int[] randArr = RandomNonRecurNumbers(x, y, z);
  for(int i = 0, n = 0; i < arr.GetLength(0) || n < x * y * z; i++) {
    for(int j = 0; j < arr.GetLength(1); j++) {
      for(int k = 0; k < arr.GetLength(2); k++, n++) {
        arr[i, j, k] = randArr[n];
        Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
  }
}

CubeArray(2, 2, 2);

//62
int[,] SpiralArray(int row, int col) {
  int[,] arr = new int[row, col];
  int count = 1;
  int sum = row * col;
  int correctY = 0;
  int correctX = 0;
  while(row > 0)
  {
    for (int i = 0; i < 4; i++) {
      for (int j = 0; j < ((col < row) ? row : col); j++) {
        if (i == 0 && j < col - correctX && count <= sum)
          arr[i + correctY, j + correctX] = count++;
        if (i == 1 && j < row - correctY && j != 0 && count <= sum)
          arr[j + correctY, col - 1] = count++;
        if (i == 2 && j < col - correctX && j != 0 && count <= sum)
          arr[row - 1, col - (j + 1)] = count++;
        if (i == 3 && j < row - (correctY + 1) && j != 0 && count <= sum)
          arr[row - (j + 1), correctY] = count++;
      }
    }
    row--;
    col--;
    correctY += 1;
    correctX += 1;
  }
  return arr;
}

PrintArrayInt(SpiralArray(4, 4));
//Сделал рекурсией

int Task25(int a, int b) {
  if(b == 0) {
    return 1;
  } else {
    return a * Task25(a, b-1);
  }
}

Console.WriteLine(Task25(3, 5));

void Task27(int number) {
  string str = Convert.ToString(number);
  int res = 0;
  for(int i = 0; i < str.Length; i++) {
    res += str[i]-'0';
  }
  Console.WriteLine(res);
}

Task27(9012);

// Слияние двух массивов

int[] CreateArr(int len) {
  int[] arr = new int[len];
  for(int i = 0; i < len; i++) {
    arr[i] = new Random().Next(-100, 100);
  }
  return arr;
}

void MergeArr(int[] arr1, int[] arr2) {
  int[] arr = new int[arr1.Length + arr2.Length];
  for(int i = 0, j = 0; i < arr.Length; i++) {
    if(i < arr1.Length) {
      arr[i] = arr1[i];
    } else {
      arr[i] = arr2[j];
      j++;
    }
  }
  Console.WriteLine($"Первый массив: {string.Join(", ", arr1)}");
  Console.WriteLine($"Второй массив: {string.Join(", ", arr2)}");
  Console.WriteLine($"Два массива в одном: {string.Join(", ", arr)}");
}

MergeArr(CreateArr(8), CreateArr(6));
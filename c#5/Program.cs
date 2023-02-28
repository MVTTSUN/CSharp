int[] CreateArr(int el, int startRange, int finishRange) {
  int[] arr = new int[el];
  for(int i = 0; i < arr.Length; i++) {
    arr[i] = new Random().Next(startRange, finishRange + 1);
  }
  return arr;
}

void Task37(int[] arr) {
  int[] newArr = new int[(arr.Length / 2) + (arr.Length % 2)];
  for(int i = 0; i < arr.Length / 2; i++) {
    newArr[i] = arr[i] * arr[^(i + 1)];
  }
  if(arr.Length % 2 == 1) {
    newArr[^1] = arr[(arr.Length / 2) + (arr.Length % 2)];
  }
  Console.WriteLine($"Исходный массив: {String.Join(" ", arr)}, перемноженный массив: {String.Join(" ", newArr)}");
}

Task37(CreateArr(7, -9, 9));

void Task34(int[] arr) {
  int count = 0;
  for(int i = 0; i < arr.Length; i++) {
    if(arr[i] % 2 == 0) {
      count++;
    }
  }
  Console.WriteLine($"Исходный массив: {String.Join(" ", arr)}, количество четных чисел в массиве: {count}");
}

Task34(CreateArr(5, 100, 999));

void Task36(int[] arr) {
  int result = 0;
  for(int i = 0; i < arr.Length; i++) {
    if(i % 2 == 1) {
      result += arr[i];
    }
  }
  Console.WriteLine($"Исходный массив: {String.Join(" ", arr)}, сумма чисел на нечетных позициях: {result}");
}

Task36(CreateArr(6, 0, 99));

void Task38(int[] arr) {
  int max = arr[0], min = arr[0];
  int result;
  for(int i = 0; i < arr.Length; i++) {
    if(arr[i] > max) {
      max = arr[i];
    }
    if(arr[i] < min) {
      min = arr[i];
    }
  }
  result = max - min;
  Console.WriteLine($"Исходный массив: {String.Join(" ", arr)}, разница между максимальным и минимальным элементом: {result}");
}

Task38(CreateArr(5, 0, 99));
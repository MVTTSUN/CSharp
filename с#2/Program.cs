// 10
void Task10(int number) {
  int result;
  if(number / 100 < 10 && number / 100 > 0) {
    result = (number / 10) % 10;
    Console.WriteLine(result);
  } else {
    Console.WriteLine("число не трёхзначное");
  }
}

Task10(467);

// 13
void Task13(int number) {
  if(number > 99) {
    string str = Convert.ToString(number);
    Console.WriteLine(str[2]);
  } else {
    Console.WriteLine("третьей цифры нет");
  }
}

Task13(14674);

//15
void Task15(int number) {
  if(number > 0 && number < 8) {
    if(number == 6 || number == 7) {
      Console.WriteLine("Выходной день");
    } else {
      Console.WriteLine("Не выходной день");
    }
  } else {
    Console.WriteLine("Вы ввели неправильное значение");
  }
}

Task15(7);

//Additional
void TaskAdditional(int number) {
  if (number % 7 == 0 && number % 23 == 0) {
    Console.WriteLine("кратно");
  } else {
    Console.WriteLine("не кратно");
  }
}

TaskAdditional(161);
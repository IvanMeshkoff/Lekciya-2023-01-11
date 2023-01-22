Console.Clear();
int number1 = new Random().Next(1, 10); // 1 2 3 ... 9
Console.WriteLine("Первое случайное число: " + number1);
int number2 = new Random().Next(-5, 6);
Console.WriteLine("Второе случайное число: " + number2);
int result = number1 + number2;
Console.WriteLine("Сумма случйных чисел = " + result);
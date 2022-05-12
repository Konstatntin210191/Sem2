int number = new Random().Next(10,100);
Console.WriteLine($"Сгенерированное число: {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

Console.WriteLine($"Первое число: {firstDigit}, второе число: {secondDigit}");

int max = firstDigit > secondDigit ? firstDigit : secondDigit;

Console.WriteLine($"Наибольшая цифра из чисел: {max}");
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
string StrFirstNumber = Console.ReadLine();

Console.WriteLine("Введите первое число: ");
string StrSecondNumber = Console.ReadLine();

int FirstNumber = int.Parse(StrFirstNumber);
int SecondNumber = int.Parse(StrSecondNumber);

int result = FirstNumber % SecondNumber;

if (result == 0)
    Console.WriteLine("Кратное");
else 
    Console.WriteLine($"Некратно, остаток {result}");


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int InputNumber (string MessageToUser)
{
    Console.Write(MessageToUser);
    return int.Parse(Console.ReadLine());
}

int ReturnSecondDigit(int n)
{
    return n / 10 % 10;
}

int num = InputNumber("Введите трехзначное число: ");
System.Console.WriteLine($"Вторая цифра трехзначного числа {num} равна {ReturnSecondDigit(num)}");
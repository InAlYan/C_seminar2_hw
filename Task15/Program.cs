// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int InputNumber(string MessageToUser)
{
    Console.Write(MessageToUser);
    return int.Parse(Console.ReadLine());
}

bool IsCorrectInput(int n)
{
    if (n < 1 || n > 7) return false;
    return true;
}

bool IsWeekend(int DayOfWeek)
{
    if (DayOfWeek == 6 || DayOfWeek == 7) return true;
    return false;
}

int number;
do
{
    number = InputNumber("Введите цифру обозначающую день недели: ");
}
while (! IsCorrectInput(number));

string message = (IsWeekend(number)) ? $"Этот день выходной" : $"Этот день не выходной";
System.Console.WriteLine(message);


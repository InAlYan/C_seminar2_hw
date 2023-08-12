// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int InputNumber(string MessageToUser)
{
    Console.Write(MessageToUser);
    return int.Parse(Console.ReadLine());
}


int CountOfPositionOfNumber(int n) //Узнать количество цифр (десятичных позиций) у числа n
{
    if (n < 0) n = -n; //Приводим число к положительному

    int count = 1; //У числа должна быть хотя бы одна цифра

    while (n > 9) //Вычисляем количество разрядов для многоразрядных чисел
    {
        n = n / 10;
        count++;
    }
    return count;
}


int DigitByPositionOfNumberFromLeft(int n, int DigitPosition)//Узнать цифру по позиции слева (DigitPosition) у числа n
{
    int CountOfDigit = CountOfPositionOfNumber(n); //Количество разрядов в числе

    if (DigitPosition < 1 || DigitPosition > CountOfDigit) return -1; //Если заданная позиции цифры в числе неразумна (меньше первой позиции или больше максимальной)

    /////////////////////////////////////////////////////////////////////////////
    // например ищем 3-ю слева цифру в числе 4567893
    // CountOfDigit = 7 (всего 7 позиций); DigitPosition = 3 (искомая третья слева позиция)    
    // 4567893 % (10 ^ 5) => 67893 / (10 ^ 4) => 6
    // отсюда общая формула
    // n % (10 ^ degree) / (10 ^ (degree - 1)),
    // где degree = CountOfDigit - DigitPosition + 1 = 7 - 3 + 1 = 5 (степень в котоую необходимо возвести 10 для получения делителя)
    /////////////////////////////////////////////////////////////////////////////

    int Degree = (CountOfDigit - DigitPosition + 1); // Степень в которую надо возвести 10, чтобы получить делитель
    int TenInDegree = Convert.ToInt32(Math.Pow(10, Degree)); // 10 в нужной степени приведенная к int
    return n % TenInDegree / (TenInDegree / 10); // Вычленяем и возвращаем цифру в нужной позиции числа по формуле: n % (10 ^ degree) / (10 ^ (degree - 1))
}

int num = InputNumber("Введите число: ");
int DigitByPosition = DigitByPositionOfNumberFromLeft(num, 3);

string message = (DigitByPosition == -1) ? $"Третьей цифры у числа {num} нет" : $"Третья цифра у числа {num} равна {DigitByPosition}";

System.Console.WriteLine(message);

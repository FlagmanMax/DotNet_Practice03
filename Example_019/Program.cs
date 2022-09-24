// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

void isPalindrom(int value)
{
    int[] array= new int[5];
    int temp = value;
    int index = 0;
    while (temp>0)
    {
        array[index] = temp%10;
        index++;
        temp = temp / 10;
    }

    if ((array[0]==array[4]) && (array[1]==array[3]))
    {
        Console.WriteLine("Число "+ value + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Число "+ value + " не является палиндромом");
    }
}

Console.WriteLine("Введите пятизначное число:");
int var = Convert.ToInt32(Console.ReadLine());

if (var<10000 && var>99999)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    isPalindrom(var);
}
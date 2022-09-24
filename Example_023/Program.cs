// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("Число\t Куб числа");

    int index = 1;
    while (index <= Math.Abs(num))
    {
        Console.WriteLine($"{index}\t {index*index*index}");
        index++;
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}
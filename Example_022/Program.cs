// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void example22(int x)
{
    int count = 1;
    Console.Write("Число\tКвадрат\r\n");
    while(count <= x)
    {
        Console.Write(count + "\t" + Math.Pow(count,2) + "\r\n");
        count++;
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());

if (x<1)
{
   Console.WriteLine("Ошибка ввода"); 
}
else
{
    example22(x);
}


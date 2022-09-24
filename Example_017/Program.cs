
// Console.WriteLine("Введите координаты точки:");
// Console.Write("x = ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("y = ");
// double y = Convert.ToDouble(Console.ReadLine());

Random random = new Random();
int x = random.Next(-10,11);
int y = random.Next(-10,11);
//Console.WriteLine($"A({x}, {y})");

void Check(int x, int y)
{
    if ((x>0)&&(y>0))
    {
        Console.WriteLine($"Точка A({x},{y}) лежит в первом квадранте");
    }
    else if ((x>0)&&(y<0))
    {
        Console.WriteLine($"Точка A({x},{y}) лежит в четвертом квадранте");
    }
    else if ((x<0)&&(y>0))
    {
        Console.WriteLine($"Точка A({x},{y}) лежит в втором квадранте");
    }
    else if ((x<0)&&(y<0))
    {
        Console.WriteLine($"Точка A({x},{y}) лежит в третьем квадранте");
    }
    else
    {
        Console.WriteLine($"Точка A({x},{y}) лежит в на оси");
    }
}

Check(x,y);

// int result;

// if (x>0)
// {
//     if (y>0)
//     {
//         result = 1;
//     }
//     else
//     {
//         result = 4;
//     }
// }
// else
// {
//     if (y>0)
//     {
//         result = 2;
//     }
//     else
//     {
//         result = 3;
//     }
// }
//Console.WriteLine($"Точка A({x},{y}) находится в квадранте {result}");
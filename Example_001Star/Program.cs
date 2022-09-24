// Задача 1. 
// На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти.
// Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

int[,] make4Points(int minX, int maxX, int minY, int maxY)
{
    int[,] x = new int[4,2]{{0,0},{0,0},{0,0},{0,0}};

    Random random = new Random();

    x[0,0] = 0;
    x[0,1] = 0;

    for (int i =1; i<4; i++)
    {
        x[i,0] = random.Next(minX,maxX);
        x[i,1] = random.Next(minY,maxY);
    }

    return x;
}

void PrintPoint(int[,] point)
{
    char[] array = new char[4]{'0','A','B','C'};
    for (int i=0; i<4; i++)
    {
        Console.WriteLine($"{array[i]}({point[i,0]}, {point[i,1]})");
    }
}

double getDistance(int[,] point, int i1, int i2)
{
    double res = 0;

    res += Math.Pow(point[i1,0] - point[i2,0],2);
    res += Math.Pow(point[i1,1] - point[i2,1],2);
    res = Math.Sqrt(res);

    return res;
}

double getLength(int[,] point, int i1, int i2, int i3)
{
    double res = 0;

    res += getDistance(point, 0, i1);
    res += getDistance(point, i1, i2);
    res += getDistance(point, i2, i3);
    res += getDistance(point, i3, 0);

    return res;
}

int minX = 0;
int maxX = 0;
int minY = 0;
int maxY = 0;

Console.WriteLine("Введите номер четверти:");
int x = Convert.ToInt32(Console.ReadLine());


if (x == 1)
{
    minX=1;
    maxX=51;
    minY=1;
    maxY=51;
}
else if (x == 2)
{
    minX=-50;
    maxX=0;
    minY=1;
    maxY=51;
}
else if (x == 3)
{
    minX=-50;
    maxX=0;
    minY=-50;
    maxY=0;
}
else if (x == 4)
{
    minX=1;
    maxX=51;
    minY=-50;
    maxY=0;
}
else
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int[,] points = new int[4,2]{{0,0},{0,0},{0,0},{0,0}};

points = make4Points(minX, maxX, minY, maxY);
PrintPoint(points);

double[] len = new double[3];

len[0] = Math.Round(getLength(points,1,2,3),3);
Console.WriteLine($"0-A-B-C-0 \t{len[0]}");
len[1] = Math.Round(getLength(points,1,3,2),3);
Console.WriteLine($"0-A-C-B-0 \t{len[1]}");
len[2] = Math.Round(getLength(points,2,1,3),3);
Console.WriteLine($"0-B-A-C-0 \t{len[2]}");





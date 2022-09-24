Random random = new Random();

int x1 = random.Next(-10,11);
int y1 = random.Next(-10,11);
Console.WriteLine($"Координаты точки А({x1},{y1}):");

int x2 = random.Next(-10,11);
int y2 = random.Next(-10,11);
Console.WriteLine($"Координаты точки B({x2},{y2}):");

double result = Math.Sqrt((x2-x1)*(x2-x1) +(y2-y1)*(y2-y1));
Console.WriteLine("Расстояние между точками A и B равно "+ Math.Round(result,3));

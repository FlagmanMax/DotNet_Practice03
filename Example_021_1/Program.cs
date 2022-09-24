// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Distance(int[] A, int[] B)
{
    double result = 0;
    for (int i=0; i<3; i++)
    {
        result += Math.Pow((A[i] - B[i]),2);
    }
    result = Math.Sqrt(result);
    
    Console.WriteLine("Расстояние между точками A и B = " + Math.Round(result,2));
}

Console.WriteLine("Меню ввода координат точек A и B:");
Console.WriteLine("\t[ 0 ] - ввод случайных значений");
Console.WriteLine("\t[ 1 ] - ввод вручную");
Console.Write("-> ");

int[] A=new int[3];
int[] B=new int[3];

int menu = Convert.ToInt32(Console.ReadLine());
if (menu == 0)
{
    Random  random = new Random();
    A[0] = random.Next(-10,11);
    A[1] = random.Next(-10,11);
    A[2] = random.Next(-10,11);
    B[0] = random.Next(-10,11);
    B[1] = random.Next(-10,11);
    B[2] = random.Next(-10,11);
}
else if (menu == 1)
{
    Console.WriteLine("Введите координаты т. A:");
    Console.Write("Ax = ");
    A[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ay = ");
    A[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Az = ");
    A[2] = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите координаты т. B:");
    Console.Write("Bx = ");
    B[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("By = ");
    B[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Bz = ");
    B[2] = Convert.ToInt32(Console.ReadLine());
}
else
{
    Console.WriteLine("Ошибка ввода");
    return;
}

Distance(A,B);

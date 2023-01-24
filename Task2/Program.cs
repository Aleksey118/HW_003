// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Distance(double ax, double ay, double az, double bx, double by, double bz)
{
    double dis = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    Console.Write($"A ({ax},{ay},{az}); B ({bx},{by},{bz}) -> " + dis);
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int ax = GetNum("Введите значение Ax: ");
int ay = GetNum("Введите значение Ay: ");
int az = GetNum("Введите значение Az: ");
int bx = GetNum("Введите значение Bx: ");
int by = GetNum("Введите значение By: ");
int bz = GetNum("Введите значение Bz: ");

Distance(ax, ay, az, bx, by, bz);
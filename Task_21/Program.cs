Console.WriteLine("Введите координаты точки А");
Console.WriteLine("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z = ");
int zA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z = ");
int zB = Convert.ToInt32(Console.ReadLine());



double distance = Distance(xA, yA, xB, yB, zA, zB);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    int catet1 = (x1 - x2);
    int catet2 = (y2 - y1);
    int catet3 = (z2 - z1);
    double hypo = Math.Sqrt(catet1 * catet1 + catet2 * catet2 + catet3 * catet3);
    return hypo;
}


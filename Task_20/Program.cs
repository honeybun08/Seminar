//Задача 20: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
//12 мин

//double d = Math.Sqrt(5); // метод извлечения корня

//double num = 5.099786;
//double numRound = Math.Round(num,2, MidpointRounding.ToZero); // метод окгругления
//Console.WriteLine(numRound);

//double pw = Math.Pow(3, 6);


Console.WriteLine("Введите координаты точки А");
Console.WriteLine("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA, yA, xB, yB);

Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    int catet1 = (x1 - x2);
    int catet2 = (y2 - y1);
    double hypo = Math.Sqrt(catet1 * catet1 + catet2 * catet2);
    return hypo;
}










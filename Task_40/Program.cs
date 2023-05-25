Console.WriteLine("Введите первую сторону ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую сторону ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью сторону ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool isTriangle(int numA, int numB, int numC)
{
    int sum = numB + numC;
    if (numA < sum) return true;
    else return false;
}

bool IsTriangle = isTriangle(numberA,numberB,numberC);
Console.WriteLine (IsTriangle ?  "Такой треугольник существует" : "Такой треугольник не существует");
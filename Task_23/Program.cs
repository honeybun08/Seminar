Console.Write("Введите положительное целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Cube(numberN);

void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3}  {count * count * count,5}");
        count++;
    }
}



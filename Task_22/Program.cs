Console.Write("Введите положительное целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Square(numberN);

void Square(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3}  {count * count,5}");
        count++;
    }
}


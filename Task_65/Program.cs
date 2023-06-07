// числа в промежутке от M до N(по возрастанию или убыванию)

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(numberM, numberN);

void NaturalNumbersRange(int numM, int numN)
{
    if (numM  > numN)
    {
    Console.Write($" {numM}");
    NaturalNumbersRange(numM - 1, numN);    // 5, 4, 3...
    }
    else if (numM < numN)
    {
    Console.Write($" {numM}");
    NaturalNumbersRange(numM + 1, numN);   // 1, 2, 3...
    }
    else Console.Write($" {numM}");
    
}




//Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от 1 до N.
// 4 -> " 1, 2, 3, 4"
// 2 -> " , 1, 2"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);


void NaturalNumbers(int num)                               
{
    // условие выхода, идем наоборот, когда num = 0
    if (num == 0) return;
    NaturalNumbers(num - 1) ;                   // должно уменьшатся
    Console.Write($"{num} ");
}

Console.WriteLine("Введите первое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine("max =");
Console.WriteLine(max);

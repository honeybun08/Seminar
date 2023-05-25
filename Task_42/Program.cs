Console.WriteLine("Введите число: "); // перевод числа в двоичную систему
int number = Convert.ToInt32(Console.ReadLine());

string result = DecToBin(number);
Console.WriteLine(result);

string DecToBin(int num)
{
    string res = string.Empty;  //res = result
    while (num > 0)
    {
        res = num % 2 + res; //если +рес после нам, то оно переварачивается
        num = num / 2;   
    }
    return res;
}

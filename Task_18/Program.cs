//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
string input = Console.ReadLine();

string range = Range (input);
Console.WriteLine(range == null ? "Некооректный ввод" : range);


string Range (string numb)
{
    if (numb == "1") return "x > 0, y > 0";
    if (numb == "2") return "x < 0, y > 0";
    if (numb == "3") return "x < 0, y < 0";
    if (numb == "4") return "x > 0, y < 0";
    return null;
}


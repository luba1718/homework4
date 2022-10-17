/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())*/

Console.WriteLine("Введите ряд чисел через запятую");

string str = Console.ReadLine();
string [] strMass = str.Split(',');

int [] numMass = new int[strMass.Length];

for (int i = 0; i < strMass.Length; i++)
{
    numMass[i] = int.Parse(strMass[i]);
}

Console.WriteLine("итоговый массив");

Console.Write("[");

for (int i = 0; i < numMass.Length; i++)
{
    if(i < numMass.Length - 1)
        Console.Write($"{numMass[i]}, ");
    else
        Console.Write($"{numMass[i]}");
        
}

Console.Write("]");

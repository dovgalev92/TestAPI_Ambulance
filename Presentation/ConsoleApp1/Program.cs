
string[] name = { "tom", "andrey", "petr" };

int next = 0, index = 0;
Console.WriteLine("Поиск самого длинного слова в массиве имен");

for(int i = 0; i < name.Length; i++)
{
    if (name[i].Length > next)
    {
        next = name[i].Length;
        index = i;
    }

}
Console.WriteLine($"самое длинное слово {name[index]}");

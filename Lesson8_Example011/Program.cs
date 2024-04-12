void FillArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int position = 0;
    while (position < col.Length)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.WriteLine();
}
int IndexOf(int[] collection, int find)
{
    int index = 0;
    int position = -1;
    while (index < collection.Length)
    {
        if (collection[index] == find)
        {
            position = index;
            break;  // чтобы получить только первое "вхождение".
        }
        index++;
    }
    return position;
}
int[] array = new int[10];  // Запомнить!
FillArray(array);
PrintArray(array);
Console.WriteLine("Индекс позиции, равной 5-ти:  " + IndexOf(array, 5));

// (Видимость переменных и их изменяемые значения:)
/*
int a = 5, b = 8, count = 5;
int Chlen(int a, int b, int count)
{
    for (int i = 0; i < count; i++)
    {
        a++;
        b--;
        Console.WriteLine($"Внутри цикла, внутри f-ции на {i+1}-ой итерации значение а: {a}");
        Console.WriteLine($"Внутри цикла, внутри f-ции на {i+1}-ой итерации значение b: {b}");
        Console.WriteLine();
    }
    Console.WriteLine($"Вне цикла, но внутри f-ции а = {a}\tВне цикла всё ещё Видит значения изменённые внутри него!");
    Console.WriteLine($"Вне цикла, но внутри f-ции b = {b}\tВне цикла всё ещё Видит значения изменённые внутри него!");
    Console.WriteLine();
    return a;
}
Console.Clear();
Console.WriteLine("Вне f-ции перед её вызовом значение а: " + a);
Console.WriteLine("Вне f-ции перед её вызовом значение b: " + b);
a = Chlen(a, b, count);
Console.WriteLine($"Вне f-ции, после её вызова значение а: {a}\t(изменилась потому ч мы сделали ''return a;'')");
Console.Write($"Вне f-ции, после её вызова значение b: {b}\t(за f-цией знач. п-меннных сбрас к значениям до вызова.)");   //*/
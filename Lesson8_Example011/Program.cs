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
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random ().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
    Console.WriteLine();
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
            {
            position = index;
            break;
            }
        index++;
    }
    return position;
}
int[] array = new int[10];  // Запомнить!
FillArray(array);
PrintArray(array);
Console.WriteLine(IndexOf(array, 5));
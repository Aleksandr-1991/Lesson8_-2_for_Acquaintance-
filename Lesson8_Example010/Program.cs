int [] array = {11, 2, 13, 71, 14, 51, 16, 71, 81};
int n = array.Length;
int find = 71;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

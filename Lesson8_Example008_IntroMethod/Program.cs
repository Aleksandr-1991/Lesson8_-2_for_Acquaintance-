int Max (int Arg1, int Arg2, int Arg3)
{
    int result = Arg1;
    if (Arg2 > result) result = Arg2;
    if (Arg3 > result) result = Arg3;
    return result;
}
int a1 = 16;
int b1 = 21;
int c1 = 38;
int a2 = 13;
int b2 = 2414;
int c2 = 36;
int a3 = 16;
int b3 = 24;
int c3 = 316;
int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = Max (a3, b3, c3);
int max = Max (max1, max2, max3);
Console.WriteLine(max);
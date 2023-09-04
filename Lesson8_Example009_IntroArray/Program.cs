int Max (int Arg1, int Arg2, int Arg3)
{
    int result = Arg1;
    if (Arg2 > result) result = Arg2;
    if (Arg3 > result) result = Arg3;
    return result;
}
int [] array = {58,13,11,7,68,72,36,76,32};

// int max1 = Max (a1, b1, c1);
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);
// int max = Max (max1, max2, max3);
// int max = Max (Max (a1, b1, c1), Max (a2, b2, c2), Max (a3, b3, c3));
int max = Max 
(
Max (array[0], array[1], array[2]), 
Max (array[3], array[4], array[5]), 
Max (array[6], array[7], array[8])
);
Console.WriteLine(max);
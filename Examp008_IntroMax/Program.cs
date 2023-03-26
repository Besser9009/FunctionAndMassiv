Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 4;
int b1 = 7;
int c1 = 12;
int d1 = 10;
int a2 = 20;
int b2 = 52;
int c2 = 0;
int d2 = -7;
int a3 = 90;
//int max1 = Max(a1, b1, c1);
//int max2 = Max(d1, a2, b2);
//int max3 = Max(c2, d2, a3);
int max = Max(Max(a1, b1, c1), Max(d1, a2, b2), Max(c2, d2, a3));

Console.Write("max = ");
Console.WriteLine(max);


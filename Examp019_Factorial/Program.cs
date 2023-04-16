//5! = 5*4*3*2*1
Console.Clear();
double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(20));
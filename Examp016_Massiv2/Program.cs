Console.Clear();
int [] num = {7, 5, 2, 4, 9, 7, 8, 10, 1, 0, 6, 3, 1};
void PrintNum(int[] num){
    int count = num.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{num[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] num)
{
    for (int i = 0; i < num.Length - 1; i++)
    {
       int maxPosition = i;
       for (int j = i + 1; j < num.Length; j++)
       {
        if(num[j] > num[maxPosition]) maxPosition = j;
       }
       int temporary = num[i];
       num[i] = num[maxPosition];
       num[maxPosition] = temporary;
    }
}
PrintNum(num);
SelectionSort(num);
PrintNum(num);
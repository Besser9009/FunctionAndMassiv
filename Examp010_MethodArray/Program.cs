int [] array = {12, 165, 120, 48, 16, 0, 67984, 167, -4946, 16};

int n = array.Length;
int find = 16;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        Console.WriteLine("End.");
        break;
    }
    index++;
}
//                0   1   2    3   4   5   6   7   8
int [] array = { 12, 52, 57, 455, 51, 16, 57, 88, 39};

int n =array.Length;
int find = 57;

int index = 0;

while (index < n)
{
    if (array[index]  == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}
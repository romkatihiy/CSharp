int[] array = { 1, 11, 14, 94, 35, 56, 14, 21 };

int n = array.Length;
int find = 14;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}

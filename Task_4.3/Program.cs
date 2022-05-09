//напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(-1, 1000);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.WriteLine(col[position]);
    }
}

FillArray(array);
PrintArray(array);

using AlgsExam;
var array = new[] {0, 1, 17, 78, 6, 10, 14, 4};
PrintArray(array);
SelectionSort.Test(array);
PrintArray(array);

static void PrintArray(int[] array)
{
    foreach (var elem in array)
    {
        Console.Write(elem + " ");
    }

    Console.WriteLine();
}
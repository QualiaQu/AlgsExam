namespace AlgsExam;

public static class QuickSort
{
    static int Partition(int[] array, int start, int end) 
    {
        int marker = start;
        for (int i = start; i < end; i++) 
        {
            if (array[i] < array[end])
            {
                (array[marker], array[i]) = (array[i], array[marker]);
                marker += 1;
            }
        }
        
        (array[marker], array[end]) = (array[end], array[marker]);

        return marker;
    }
    public static void Sort(int[] array, int start, int end)
    {
        if (start >= end) 
            return;

        int pivot = Partition (array, start, end);
        Sort(array, start, pivot - 1);
        Sort(array, pivot + 1, end);
    }
}
namespace AlgsExam;

public static class ShakerSort
{
    // Алгоритм представляет собой одну из разновидностей «сортировки пузырьком«. 
    // Основное отличие заключается в том, что в классической сортировке пузырьком происходит однонаправленное движение элементов 
    // (слева — направо), в то время, как сортировке перемешиванием мы сначала проходим слева-направл, а затем справа-налево.
    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            var swapFlag = false;
            //слева направо
            for (int j = i; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapFlag = true;
                }
            }
            //справа налево
            for (int j = arr.Length - 2 - i; j > i; j--)
            {
                if (arr[j - 1] > arr[j])
                {
                    (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
                    swapFlag = true;
                }
            }
        
            if (!swapFlag) break;
        }  
    }
}
namespace AlgsExam;
//Слева в руке у нас уже есть часть карт, которые отсортированы по порядку.
//А справа, допустим, карты, которые только хотим отсортировать.
//Мы берём очередную карту и помещаем ("вставляем") в уже отсортированную часть.
//Вставляем карту, найдя ей соответсвующее место.

public static class InsertionSort
{
    public static void Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int k = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > k) 
            {
                array[j + 1] = array[j];
                array[j] = k;
                j--;
            }
        }
    }

    public static void Test(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int k = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > k)
            {
                array[j + 1] = array[j];
                array[j] = k;
                j--;
            }
        }
    }
}
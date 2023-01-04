namespace AlgsExam;
// Алгоритм заключается в циклических проходах по массиву,
// за каждый проход элементы массива попарно сравниваются и,
// если их порядок не правильный, то осуществляется обмен.
// Обход массива повторяется до тех пор, пока массив не будет упорядочен.
public static class BubbleSort
{
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
        }
    }
}
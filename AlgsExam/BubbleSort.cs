namespace AlgsExam;
// Алгоритм заключается в циклических проходах по массиву,
// за каждый проход элементы массива попарно сравниваются и,
// если их порядок не правильный, то осуществляется обмен.
// Обход массива повторяется до тех пор, пока массив не будет упорядочен.
public static class BubbleSort
{
    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                }
            }
        }
    }
}
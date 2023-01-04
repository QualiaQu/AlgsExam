using System.Globalization;

namespace AlgsExam;

public static class SelectionSort
{
// Находим минимальный элемент в массиве.
// Меняем местами минимальный и первый элемент местами.
// Ищем минимальный элемент в неотсортированной части массива, т.е., начиная уже со второго элемента массива.
// Меняем местами второй элемент массива и найденный минимальный.
// Ищем минимальный элемент в массиве, начиная с третьего, меняем местами третий и минимальный элементы.
// Продолжаем алгоритм до тех пор пока не дойдем то конца массива.
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int min = i;
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            (array[min], array[i]) = (array[i], array[min]);
        }
    }

    public static void Test(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int min = i;
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }

            (arr[i], arr[min]) = (arr[min], arr[i]);
        }
    }
}
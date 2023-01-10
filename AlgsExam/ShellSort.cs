namespace AlgsExam;

public static class ShellSort
{
    public static void Sort(int[] arr)
    {
        var step = arr.Length / 2;
        while (step >= 1)
        {
            for (int i = step; i < arr.Length; i++)
            {
                var j = i;
                while (j >= step && arr[j - step] > arr[j])
                {
                    (arr[j], arr[j - step]) = (arr[j - step], arr[j]);
                    j -= step;
                }
            }
    
            step /= 2;
        }
    }

    public static void Test(int[] arr)
    {
        var step = arr.Length / 2;
        while (step > 1)
        {
            for (int i = step; i < arr.Length; i++)
            {
                var j = i;
                while (j >= step && arr[j - step] < arr[step])
                {
                    (arr[step], arr[j - step]) = (arr[j - step], arr[step]);
                    j -= step;
                }
            }
            step /= 2;
        }
    }
}
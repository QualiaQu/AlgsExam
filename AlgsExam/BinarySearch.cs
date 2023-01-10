namespace AlgsExam;

public static class BinarySearch
{
    public static int Search(int[] arr, int value, int left, int right)
    {
        while (left <= right)
        {
            var middle = (left + right) / 2;
            if (value == arr[middle])
            {
                return middle;
            }

            if (value < arr[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public static int Test(int[] arr, int value, int left, int right)
    {
        while (left <= right)
        {
            var middle = (left + right) / 2;
            if (value == arr[middle])
            {
                return middle;
            }
            else if (value < arr[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        
        return -1;
    }
}
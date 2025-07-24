namespace DataStructureAndAlgorithms.Algorithms.Sorting;

public class QuickSort
{
    public static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            var pi = Partition(arr, left, right);
            Sort(arr, left, pi - 1);
            Sort(arr, pi + 1, right);
        }
               
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
        return i + 1;
    }
}
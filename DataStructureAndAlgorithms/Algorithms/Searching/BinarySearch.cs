namespace DataStructureAndAlgorithms.Algorithms.Searching;

public class BinarySearch
{
    public static int Search(int[] arr, int target, int low, int high)
    {
        while (low <= high)
        {
            var middle = (low + high) / 2;
            if(arr[middle] == target)
                return middle;
            if (arr[middle] < target)
            {
                high = middle - 1;
            }
            else
            {
                low = middle + 1;
            }
        }
        return -1;
    }
}
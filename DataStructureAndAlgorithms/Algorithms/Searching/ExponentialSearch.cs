namespace DataStructureAndAlgorithms.Algorithms.Searching;

public class ExponentialSearch
{
    public int Search(int[] arr, int target)
    {
        if (arr[0] == target)
            return 0;
        int i = 1;
        while (arr[i] < target && i < arr.Length)
            i = i * 2;
        if (arr[i] == target)
            return i;
        return BinarySearch.Search(arr, target, i /2, Math.Min(i, arr.Length - 1));
    }
}
namespace DataStructureAndAlgorithms.Algorithms.Techniques;

public class TwoPointer
{
    // Exemplo para o problema Two Sum Sorted
    public static int[] __TwoPointer(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            if(arr[left] + arr[right] == target)
                return [arr[left], arr[right]];
            if(arr[left] + arr[right] > target)
                right--;
            else
                left++;
        }
        return [0];
    }
}
namespace DataStructureAndAlgorithms.Algorithms.Techniques;

// Leetcode 238
public class PrefixAndSuffix
{
    public int[] ProductExceptSelf(int[] arr)
    {
        var n =  arr.Length;
        var l_arr = new int[n];
        var r_arr = new int[n];
        var result = new int[n];

        l_arr[0] = 1;
        for (int i = 1; i < n; i++)
        {
            l_arr[i] = l_arr[i-1] * arr[i-1];
        }
        
        r_arr[n-1] = 1;
        for (int j = n - 2; j >= 0; j--)
        {
            r_arr[j] = r_arr[j+1] * arr[j+1];
        }

        for (int k = 0; k < n; k++)
        {
            result[k] = l_arr[k] * r_arr[k];
        }
        return result;
    }
}
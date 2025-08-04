namespace DataStructureAndAlgorithms.Algorithms.Binaries;

public class CountingBits
{
    public int[] CountBits(int n)
    {
        var ans = new int[n];
        for (int i = 0; i <= n; i++)
        {
            var num = i;
            var count = 0;
            while (num != 0)
            {
                if ((num & 1) == 1)
                    count++;
                num >>= 1;
            }
            ans[i] = count;
        }
        return ans;
    }
}
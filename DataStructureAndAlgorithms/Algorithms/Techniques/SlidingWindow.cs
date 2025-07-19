namespace DataStructureAndAlgorithms.Algorithms.Techniques;

public class SlidingWindow
{
    // exemplo de implementação com o exercicio 3090. Maximum Length Substring With Two Occurrences do leetcode
    public static int MaximumLengthSubstring(string s) 
    {
        var l = 0;
        var map = new Dictionary<char, int>();
        var max = 0;

        for(var r=0; r<s.Length; r++)
        {
            if(!map.ContainsKey(s[r]))
                map[s[r]] = 1;
            else
                map[s[r]]++;

            while(map[s[r]] > 2)
            {
                map[s[l]]--;
                l++;
            }
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
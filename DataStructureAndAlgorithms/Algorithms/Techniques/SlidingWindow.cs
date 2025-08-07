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
    
    // Longest Substring Without Repeating Characteres LeetCode 3.
    public int LengthOfLongestSubstring(string s)
    {
        int l = 0, r = 0, maxLen = 0;
        var set = new HashSet<char>();

        while (r < s.Length)
        {
            if (!set.Contains(s[r]))
            {
                set.Add(s[r]);
                maxLen = Math.Max(maxLen, r - l + 1);
                r++;
            }
            else
            {
                set.Remove(s[l]);
                l++;
            }
        }
        return maxLen;
    }
}
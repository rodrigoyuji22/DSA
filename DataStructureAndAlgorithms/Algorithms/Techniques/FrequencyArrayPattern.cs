namespace DataStructureAndAlgorithms.Algorithms.Techniques;

public class FrequencyArrayPattern
{
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        foreach(var word in strs)
        {
            var count = new int[26];
            foreach(var c in word)
            {
                count[c - 'a']++;
            }
            var key = string.Join("#", count);
            if(!map.ContainsKey(key))
                map[key] = new List<string>();
            map[key].Add(word);
        }
        return map.Values.ToArray<IList<string>>();
    }
}
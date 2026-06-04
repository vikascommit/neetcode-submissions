public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict = new();
        foreach(string str in strs)
        {
            string key = GetKey(str);
            if(dict.ContainsKey(key))
            {
                List<string> local= new();
                local = dict[key];
                local.Add(str);
                dict[key] = local;
            }
            else
            {
                List<string> local= new();
                local.Add(str);
                dict[key] = local;
            }
        }
        List<List<string>> result = new(); 
        foreach (List<string> value in dict.Values)
        {
            result.Add(value);
        }
        return result;
    }
    
    public string GetKey(string s)
    {
        int[] counts = new int[26];
        foreach(char ch in s)
        {
            counts[ch - 'a']++;
        }
        return string.Join(',',counts);
    }
}

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Count() != t.Count())
        {
            return false;
        }
        else
        {
            Dictionary<char, int> dict1 = GetDictionary(s);
            Dictionary<char, int> dict2 = GetDictionary(t);
            foreach(char ch in dict1.Keys)
            {
                if(!dict2.ContainsKey(ch))
                {
                    return false;
                }
                if(dict1[ch] != dict2[ch])
                {
                    return false;
                }
            }
        }
        return true;        
    }

    public Dictionary<char, int> GetDictionary(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char ch in s)
        {
            if(dict.ContainsKey(ch))
            {
                int count = dict[ch];
                dict[ch] = count + 1;
            }
            else
            {
                dict.Add(ch,1);
            }            
        }
        return dict;
    }
}

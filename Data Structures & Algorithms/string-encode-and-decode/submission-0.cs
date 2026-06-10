public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder result = new StringBuilder();
        foreach(string s in strs)
        {
            result.Append(s.Length).Append("#").Append(s);
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while(i<s.Length)
        {
            int index = s.IndexOf('#',i);
            int length = int.Parse(s.Substring(i,index-i));
            string str = s.Substring(index+1,length);
            result.Add(str);
            i = index+1+length;
        }
        return result;
   }
}

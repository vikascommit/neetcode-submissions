public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int> ();
        foreach(int num in nums)
        {
            if(dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num]=1;
            }
        }
        List<int>[] buckets = new List<int>[nums.Length+1];
        for(int i=0; i<buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }
        foreach(var pair in dict)
        {
            int number = pair.Key;
            int frequency = pair.Value;
            buckets[frequency].Add(number);
        }

        List<int> result = new List<int>();
        for(int i=buckets.Length-1; i>0 && result.Count()<k; i--)
        {
            foreach(int num in buckets[i])
            result.Add(num);
        }
        return result.ToArray();
    }
}

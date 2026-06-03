public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        Dictionary<int, int> dict = new Dictionary<int,int>();
        for(int i=0; i<nums.Length; i++)
        {
            int diff = target - nums[i];            
            if(dict.ContainsKey(diff))
            {
                result[0] = dict[diff];
                result[1] = i;
                break;               
            }
            else
            {
                dict.Add(nums[i],i);
            }
        } 
        return(result);          
    }
}

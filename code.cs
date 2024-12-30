public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            // finding the second number by subtracting it from target sum
            int complement = target - nums[i];
            
            if (map.ContainsKey(complement)) {
                // if map contains the complement tehn return both the indices
                return new int[] { map[complement], i };
            }
            
            if (!map.ContainsKey(nums[i])) {
                // if map does not contain current element then store it in map
                map[nums[i]] = i;
            }
        }
        // if not found then return
        return new int[] { -1, -1};
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashmap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            int complement = target - nums[i];
            if (hashmap.ContainsKey(complement)){
                return new int[] {i, hashmap[complement]};
            }
            hashmap[nums[i]] = i;
        }
        return null;
    }
}

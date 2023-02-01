public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] > 0) {
                break;
            }
            if (i == 0 || nums[i] != nums[i-1]){
                twoSum(nums, i, result);
            }
        }
        return result;
    }

    public void twoSum(int[] nums, int i, IList<IList<int>> result) {
        HashSet<int> hashset = new HashSet<int>();
        for (int j = i+1; j < nums.Length; j++){
            int complement = 0 - nums[i] - nums[j];
            if (hashset.Contains(complement)){
                result.Add(new int[] {nums[i], nums[j], complement});
                while (j+1 < nums.Length && nums[j] == nums[j+1]){
                    j++;
                }
            }
            hashset.Add(nums[j]);
        }
    }
}

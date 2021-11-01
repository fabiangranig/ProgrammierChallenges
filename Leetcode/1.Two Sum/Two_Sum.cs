public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] zahl = new Int32[2];
        bool schalter = false;
        for (int zaehler = 0; zaehler < nums.Length; zaehler++)
        {
            for (int zaehler2 = 0; zaehler2 < nums.Length - 1; zaehler2++)
            {
                if (nums[zaehler] + nums[zaehler2] == target && zaehler != zaehler2)
                {
                    zahl[0] = zaehler;
                    zahl[1] = zaehler2;
                }
            }
        }
        return zahl;
    }
}
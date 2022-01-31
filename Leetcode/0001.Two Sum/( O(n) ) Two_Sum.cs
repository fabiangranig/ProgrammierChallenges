public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Best runtime: 170 ms
        //Best storage usage: 42.1 MB
        
        //Create an array to return the solution
        int[] ar = new int[2];
        
        //Get the solution with an for-loop
        //Create an Hashmap
        Hashtable mTable = new Hashtable();
        for(int i = 0; i < nums.Length; i++)
        {
            if(mTable.ContainsKey(target - nums[i]))
            {
                ar[0] = i;
                string quicksave = (string)mTable[target - nums[i]];
                ar[1] = Int32.Parse(quicksave);
                
                //Return the array
                return ar;
            }
            else
            {
                if(mTable.ContainsKey(nums[i]))
                {
                    
                }
                else
                {
                    mTable.Add(nums[i], Convert.ToString(i));
                } 
            }
        }
        
        //if there is no answer return the empty array
        return ar;
    }
}
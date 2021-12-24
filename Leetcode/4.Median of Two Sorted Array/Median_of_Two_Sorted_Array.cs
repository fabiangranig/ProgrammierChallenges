public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        //Add the arrays togheter
        //Create an array where to safe them in
        int[] complete_array = new int[nums1.Length + nums2.Length];

        //Combine the arrays with an for-loop
        for (int i = 0; i < nums1.Length; i++)
        {
            complete_array[i] = nums1[i];
        }
        //Combine the arrays with an for-loop
        for (int i = 0; i < nums2.Length; i++)
        {
            complete_array[i + nums1.Length] = nums2[i];
        }

        //Sort the array
        Array.Sort(complete_array);

        //Get the array length
        int length = complete_array.Length;

        //Now important is if it is an even- or uneven length
        int item1;
        int item2;
        if (length % 2 == 0)
        {
            item1 = complete_array[(length / 2) - 1];
            item2 = complete_array[(length / 2)];

            //Return the solution for even number
            double solution = item1 + item2;
            solution = solution / 2.0;
            return solution;
        }
        if (length % 2 == 1)
        {
            int median = (length / 2);
            item1 = complete_array[median];
            return item1;
        }

        //If no answer was found
        return -1;
    }
}
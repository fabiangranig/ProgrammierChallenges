public class Solution {
    public bool IsPalindrome(int x) {
        //Best runtime: 44 ms
        //Best storage usage: 30.4 MB
        
        //Creatae an solution bool
        bool solution = true;
        
        //Convert the int into an string
        string input = Convert.ToString(x);
        
        //Get the legth of one site
        int length_pali = input.Length / 2;
        
        //Compare both sites if they are the same
        for(int i = 0; i < length_pali; i++)
        {
            //Check if the character from the  first half are the same with the second half
            if(input[i] != input[input.Length - 1 - i])
            {
                solution = false;
            }
        }
        
        //Return the solution
        return solution;
    }
}
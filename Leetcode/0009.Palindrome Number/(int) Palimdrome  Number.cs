public class Solution {
    public bool IsPalindrome(int x) {
        //Best runtime: 56 ms
        //Best storage usage: 32.2 MB
        
        //Creatae an solution bool
        bool solution = true;
        
        //Go through with while and when it hits 0 stop
        //Create temporary array
        List<int> vs = new List<int>();
        while(x != 0)
        {
            //Get the remainder and save it into the array
            int y = x % 10;
            vs.Add(y);
            x = x / 10;
            
            //if the remainder is minus it is false
            if(y < 0)
            {
                return false;
            }
        }
        
        //Get the half of the array
        int length_pali = vs.Count / 2;
        
        //Go through the number array and check if it is a palindrome
        for(int i = 0; i < length_pali; i++)
        {
            //Check if the first and the last character are the same and so on
            if(vs[i] != vs[vs.Count - 1 - i])
            {
                return false;
            }
        }
        
        //Return the solution
        return solution;
    }
}
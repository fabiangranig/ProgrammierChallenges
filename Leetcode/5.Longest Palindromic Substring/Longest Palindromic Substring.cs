public class Solution {
    public string LongestPalindrome(string s) {
        //Save slot for the longest string
        string save = "";
        
        //Check some simple steps that would make calculating linear
        //If the string is only one character instantly return that character
        if(s.Length == 1)
        {
            return Convert.ToString(s[0]);
        }
        //If the string is in a mirror the same just output the string
        if(is_this_Palindrome(s))
        {
            return s;
        }
        
        //Check every start character if it is a "Palindromic" Substring
        for(int i = 0; i < s.Length; i++)
        {
            for(int u = 0; u < s.Length + 1 - i; u++)
            {
                string temp2 = s.Substring(i, u);
                
                //Checking if the string is Palindrome
                if(is_this_Palindrome(temp2))
                {
                    string substring = temp2;
                    int length = substring.Length;
                    
                    //Check if the new string is longer then the old one
                    if(length > save.Length)
                    {
                        save = substring;
                    }
                }
            }
        }
        
        //If the Palindrom is just one character return that
        if(save == "")
        {
            return Convert.ToString(s[0]);
        }
        
        //Return the solution
        return save;
    }
    
    public bool is_this_Palindrome(string r)
    {
        //Get the length of the palindrome
        int string_length = r.Length;

        //Check if it is even or uneven and then decide how often a for-loop should count down
        if (string_length % 2 == 0)
        {
            string_length = string_length / 2;
        }
        else
        {
            int temp = string_length - 1;
            string_length = temp / 2;
        }

        //Now check if it is a Palindrom
        //Create an bool do decide if it is or not
        bool solution = false;

        //Now go with 2 for-loop to check
        for (int i = 0; i < string_length; i++)
        {
            if (r[i] == r[r.Length - 1 - i])
            {
                solution = true;
            }
            else
            {
                return false;
            }
        }

        //After the calculation return the solution
        return solution;
    }
}
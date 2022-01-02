public class Solution {
    public string Convert(string s, int numRows) {
        //Declare a solution array
        string[] parts = new string[numRows];
        
        //Create a while with that we can go through the characters
        int i = 0;
        int position = 0;
        int position_counter = 1;
        while(i < s.Length)
        {
            //Put the character into the array
            parts[position] += s.Substring(i, 1);
            
            //if-Condotions where the position has to move next
            if(position == numRows - 1)
            {
                position_counter = -1;
            }
            if(position == 0)
            {
                position_counter = 1;
            }
            
            //Select the next character
            i++;
            if(numRows != 1)
            {
                position = position + position_counter;
            }
        }
        
        //Put the parts togheter
        string solution = "";
        for(int o = 0; o < parts.Length; o++)
        {
            solution += parts[o];
        }
        
        //Return the solution
        return solution;
    }
}
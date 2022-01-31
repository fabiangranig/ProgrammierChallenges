public class Solution {
    public string Convert(string s, int numRows) {
        //Here is a space for the solution
        string solution = "";
        
        //Get the ladder height and the strings length
        int string_length = s.Length;
        int ladder_height = numRows - 2;
        
        //Fast-Exit: if num Rows is 1 the string can be returned
        if(numRows == 1 || s.Length <= numRows)
        {
            return s;
        }
        
        //Get the remainder after the ladder thing
        int division = string_length / (numRows + ladder_height);
        int remainder = string_length % (numRows + ladder_height);
        
        //Calculate the the new string
        string[] parts = new string[numRows];
        
        //Go through with for-loop and add to the array elements
        for(int i = 0; i < parts.Length; i++)
        {
            //???
            int last_number = 0;
            
            //for-loop to go move through the string
            for(int u = 0; u < division; u++)
            {
                //if the line is not 0 or the max length the stair is needed to add
                if(i != 0 && i != (parts.Length - 1) && u != 0)
                {
                    //Add the stairs parts
                    parts[i] += s.Substring(u * (numRows + ladder_height) - i, 1);
                }
                
                //Calculate the column
                parts[i] += s.Substring(u * (numRows + ladder_height) + i, 1);
                
                last_number = u;
            }
            
            //if the line is not 0 or the max length the stair is needed to add
            if(i != 0 && i != (parts.Length - 1) && last_number != 0)
            {
                //Add the stairs parts
                parts[i] += s.Substring((last_number + 1) * (numRows + ladder_height) - i, 1);
            }
            
            if(i != 0 && i != (parts.Length - 1) && s.Length <= numRows + ladder_height && numRows < 4)
            {
                //Add the stairs parts
                parts[i] += s.Substring((last_number + 1) * (numRows + ladder_height) - i, 1);
            }
            
            if(i != 0 && i != (parts.Length - 1) && division == 1 && s.Length > numRows + ladder_height)
            {
                //Add the stairs parts
                parts[i] += s.Substring((last_number + 1) * (numRows + ladder_height) - i, 1);
            }
        }
        
        //Add the parts which are missing at the end
        if(remainder < numRows)
        {
            for(int i = 0; i < remainder; i++)
            {
                parts[i] += s.Substring(s.Length - remainder + i, 1); 
            }
        }
        
        //Put togheter the string
        for(int i = 0; i < parts.Length; i++)
        {
            solution += parts[i];
        }
        
        //Return the solution
        return solution;
    }
}
public class Solution {
    public int MyAtoi(string s) {
        //Make the s string larger by one for the calaculations
        s += "a";
        
        //Make a start integer which is used if no value is found
        int solution = 0;
        
        //String where are plus and minus, and all numbers are saved
        string record = "";
        
        //Bools for the for-loops
        bool got_first = false;
        bool only_plus_or_minus = false;
        bool found_something = false;
        
        //for-Loop for the calaculation
        for(int i = 0; i < s.Length - 1; i++)
        {
            //When one character is already added here the last ones get added
            if(got_first == true)
            {
                //don't count the starting zeros
                if(s[i] != '0')
                {
                    //When the starting number is not a zero, activate the bool which adds numbers
                    only_plus_or_minus = false;
                }
                
                //Here the numbers after the first one get added
                if(only_plus_or_minus == false)
                {
                    record += Convert.ToString(s[i]);
                }
            }
            
            //Conditions for the task 1
            if(valid_char(s[i]) && got_first == false && s[i] != '0')
            {
                record += Convert.ToString(s[i]);
                got_first = true;
                
                if(record == "+" || record == "-")
                {
                    only_plus_or_minus = true;
                }
                
                found_something = true;
            }
            
            //Conditions for the task 2
            if(valid_char(s[i]) && got_first == false && s[i] == '0' && !valid_char(s[i+1]))
            {
                record += Convert.ToString(s[i]);
                got_first = true;
                
                if(record == "+" || record == "-")
                {
                    only_plus_or_minus = true;
                }
                
                found_something = true;
            }
            
            //Conditions for the task 3
            if(!valid_char(s[i+1]) && got_first == true)
            {
                break;
            }
            
            //Conditions for the task 4
            if(valid_char_plus_or_minus(s[i+1]) && got_first == true)
            {
                break;
            }
            
            //Conditions for the task 5
            if(!valid_char(s[i]) && s[i] != ' ')
            {
                return 0;
            }
            
            //Conditions for the task 6
            if(got_first == false && s[i] == '0' && s[i+1] == '-')
            {
                return 0;
            }
            
            //Conditions for the task 7
            if(got_first == false && s[i] == '0' && s[i+1] == '+')
            {
                return 0;
            }
        }
        
        //When nothing was found the record is set to zero
        //When there is only plus or minus the value is set to zero
        if(only_plus_or_minus == true || found_something == false)
        {
            record = "0";
        }
        
        //if the number is too long it gets shortened
        if(record.Length > 18)
        {
            //String to quicksave
            string newrecord = "";
            
            //Only use eleven numbers
            for(int i = 0; i < 11; i++)
            {
                newrecord += Convert.ToString(record[i]);
            }
            
            //Set the quicksave as record
            record = newrecord;
        }
        
        //Convert the big number into an long integer
        long solution2 = Int64.Parse(record);
        
        //If the number is too high make it smaller
        //If the number is too low make it higher
        //numbers are set to the 32 Bit Limit
        if(solution2 > 2147483647)
        {
            solution2 = 2147483647;
        }
        else
        {
            if(solution2 < -2147483648)
            {
                solution2 = -2147483648;
            }
        }
        
        //If the number is below the 32 Bit Limit convert it to a integer
        solution = Convert.ToInt32(solution2);
        
        //Return the solution
        return solution;
    }
    
    //Function which check if the char is accours in a presetted list
    public bool valid_char(char z) {
        //Create an bolean which tells if the character is an number
        bool sol = false;
        
        //Create an array and then put in that array all numbers
        char[] numbers_all = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-'};
        
        //Iterate through the array and check if the char is in there
        for(int i = 0; i < numbers_all.Length; i++)
        {
            //Check with an if-Condition if it is a number
            if(numbers_all[i] == z)
            {
                sol = true;
            }
        }
        
        //Return the solution
        return sol;
    }
    
    //Function which checks if the char is '+' or '-'
    public bool valid_char_plus_or_minus(char z) {
        //Create an bolean which tells if the character is an number
        bool sol = false;
        
        //Create an array and then put in that array all numbers
        char[] numbers_all = {'+', '-'};
        
        //Iterate through the array and check if the char is in there
        for(int i = 0; i < numbers_all.Length; i++)
        {
            //Check with an if-Condition if it is a number
            if(numbers_all[i] == z)
            {
                sol = true;
            }
        }
        
        //Return the solution
        return sol;
    }
}
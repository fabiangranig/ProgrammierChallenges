public class Solution {
    public int MyAtoi(string s) {
        //Make the s string one larger
        s += "p";
        
        //Make a start integer which is used if no value is found
        int solution = 0;
        
        //Go through the string at record the number with + and -
        string record = "";
        bool got_first = false;
        bool only_plus_or_minus = false;
        bool found_something = false;
        for(int i = 0; i < s.Length - 1; i++)
        {
            if(got_first == true)
            {
                if(s[i] != '0')
                {
                    only_plus_or_minus = false;
                }
                
                if(only_plus_or_minus == false)
                {
                    record += Convert.ToString(s[i]);
                }
            }
            
            if(valid_char(s[i]) && got_first == false && s[i] != '0' || valid_char(s[i]) && got_first == false && s[i] == '0' && !valid_char(s[i+1]))
            {
                record += Convert.ToString(s[i]);
                got_first = true;
                
                if(record == "+" || record == "-")
                {
                    only_plus_or_minus = true;
                }
                
                found_something = true;
            }
            
            if(!valid_char(s[i+1]) && got_first == true || valid_char_plus_or_minus(s[i+1]) && got_first == true)
            {
                break;
            }
            
            if(!valid_char(s[i]) && s[i] != ' ' || got_first == false && s[i] == '0' && s[i+1] == '-' || got_first == false && s[i] == '0' && s[i+1] == '+')
            {
                return 0;
            }
        }
        
        if(only_plus_or_minus == true || found_something == false)
        {
            record = "0";
        }
        
        
        if(record.Length > 18)
        {
            string newrecord = "";
            for(int i = 0; i < 11; i++)
            {
                newrecord += Convert.ToString(record[i]);
            }
            record = newrecord;
        }
        
        long solution2 = Int64.Parse(record);
        
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
        
        solution = Convert.ToInt32(solution2);
        
        //Return the solution
        return solution;
    }
    
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
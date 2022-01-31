public class Solution {
    public int RomanToInt(string s) {
        //Best runtime: 60ms
        //Best storage usage: 40.5 MB
        
        //Array of the double values
        string[] arr = new String[6];
        arr[0] = "IV";
        arr[1] = "IX";
        arr[2] = "XL";
        arr[3] = "XC";
        arr[4] = "CD";
        arr[5] = "CM";
        
        //Go through with a for loop an sort the characters into an array
        string[] save = new String[s.Length];
        for(int i = 0; i < s.Length; i++)
        {
            //Only check when there are two characters left
            bool h = false;
            if(s.Length - 1 == i)
            {
                
            }
            else
            {
                //Check with for loop if this is a hooked up character
                for(int i2 = 0; i2 < arr.Length; i2++)
                {
                    if(Convert.ToString(s[i]) + Convert.ToString(s[i+1]) == arr[i2])
                    {
                        h = true;
                    }
                }
            }
                
            //When there are two chracters that hooked up togheter
            if(h == true)
            {
                //At these two chracters into the array
                save[i] = Convert.ToString(s[i]) + Convert.ToString(s[i+1]);
                
                //Skip that one character
                i++;
            }
            else
            {
                save[i] = Convert.ToString(s[i]);
            }
        }
        
        //Count the symbols in the array
        int sum = 0;
        for(int i = 0; i < save.Length; i++)
        {
            switch(save[i])
            {
                //Normal numbers
                case "I":
                    sum += 1;
                    break;
                case "V":
                    sum += 5;
                    break;
                case "X":
                    sum += 10;
                    break;
                case "L":
                    sum += 50;
                    break;
                case "C":
                    sum += 100;
                    break;
                case "D":
                    sum += 500;
                    break;
                case "M":
                    sum += 1000;
                    break;
                case "IV":
                    sum += 4;
                    break;
                case "IX":
                    sum += 9;
                    break;
                case "XL":
                    sum += 40;
                    break;
                case "XC":
                    sum += 90;
                    break;
                case "CD":
                    sum += 400;
                    break;
                case "CM":
                    sum += 900;
                    break;
                default:
                    sum += 0;
                    break;
            }
        }
        
        //Return the solution
        return sum;
    }
}
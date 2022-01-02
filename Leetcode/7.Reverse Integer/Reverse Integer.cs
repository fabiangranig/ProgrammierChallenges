public class Solution {
    public int Reverse(int x) {
        //Convert the integer integer into an string
        string y = Convert.ToString(x);
        
        //Check if minus is up front when that is so make the bool true
        bool minus = false;
        if(y[0] == '-')
        {
            minus = true;
            y = y.Substring(1, y.Length - 1);
        }
        
        //Reverse the integer
        string s = "";
        
        //Check if the string requires an minus
        if(minus == true)
        {
            s += "-";
        }
        
        //Go throught it from the back and end at the front
        for(int i = 0; i < y.Length; i++)
        {
            s += Convert.ToString(y[y.Length - 1 - i]);
        }
        
        //Convert the string into an long
        long sol = Int64.Parse(s);
        
        //if the interger goes out of the 32 bit range, return 0
        if(sol >= Math.Pow(2, 31) - 1 || sol <= -2147483647)
        {
            return 0;
        }
        
        //If it is lower than an 32 bit integer convert it into a 32 bit integer
        int sol2 = Convert.ToInt32(sol);
        
        //Return the solution
        return sol2;
    }
}
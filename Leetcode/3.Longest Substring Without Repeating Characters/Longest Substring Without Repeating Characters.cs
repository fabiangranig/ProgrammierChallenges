public class Solution {
    public int LengthOfLongestSubstring(string s) {
        string endstring = "";
            int ergebnis = 0;

            if (s.Length == 1)
            {
                ergebnis = 1;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (endstring.Contains(s[i]))
                    {
                        if (endstring.Length > ergebnis)
                        {
                            ergebnis = endstring.Length;
                        }

                        int zahl = endstring.IndexOf(s[i]);
                        endstring = endstring.Substring(zahl + 1);
                        endstring += s[i];
                    }
                    else
                    {
                        endstring += s[i];
                    }
                }
                if (endstring.Length > ergebnis)
                {
                    ergebnis = endstring.Length;
                }
            }

            return ergebnis;
    }
}
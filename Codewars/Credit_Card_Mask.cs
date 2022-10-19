using System;

public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    string result = "";
    for(int i = 0; i < cc.Length; i++)
    {
      int length1 = cc.Length - 4;
      if(i < length1)
      {
        result += "#";
      }
      else
      {
        result += Convert.ToString(cc[i]);
      }
    }
    
    //Return the solution
    return result;
  }
}
using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        string replacedqm = Regex.Replace(input, "[0-9]", "?");

    }
}
sing System;

class MainClass {

  public static string StringPeriods(string str) {
    //check the length of the string is equal to 1 return -1
    //find the substring of str
    //find thelongest substring
    //chaeck if the remainderstring contains the substring, if it contains then it is the repeating substring
  if(str.Length==1){
    return "-1";
  }
    string sub="";
   string longestsubstring="";
  
    for(int i=0; i<str.Length; i++)
    {
      for(int j=0; j< str.Length-i; j++)
      {
        sub=str.Substring(i,j+1);
      
        string remainderstring=str.Substring(j+1);
     

        if( remainderstring.Contains(sub)){
          if(sub.Length>longestsubstring.Length)
          {
              longestsubstring=sub;
          }
          else
          {
           longestsubstring="-1";
          }

        }
      }
    }

  
    return longestsubstring;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(StringPeriods(Console.ReadLine()));
  } 

}
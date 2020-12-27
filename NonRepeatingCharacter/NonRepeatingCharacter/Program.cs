using System;
using System.Collections.Generic;
class MainClass
{

    public static char NonrepeatingCharacter(string str)
    {

        Char[] strArr = str.ToCharArray();

        List<char> word = new List<char>();

        //ArrayList = new ArrayList();


        for (int i =0; i < strArr.Length; i++)
        {
            if (!word.Contains(strArr[i])){
                word.Add(strArr[i]);
                Console.WriteLine("the character appended is {strArr[i]}");
            }
            else
            {
                word.Remove(strArr[i]);
            }
        }
        return word[0];
    }
    static void Main()
    {
        // keep this function call here
        string str = "1,2,e,s,2,1,e,a,k";
        Console.WriteLine(NonrepeatingCharacter(str));

    }
}

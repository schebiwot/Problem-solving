using System;
using System.Linq;


//The password should have:
//1. min 6 char and max 12 char
//2. No two similar chars consecutively
//3. 1 lower case
//4. 1 upper case
//5. 1 special char
//6. No white space

namespace Password_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPassword("Klmno&"));
        }



    //Write password checker method - must contain min 6 char and max 12 char,
    //No two similar chars consecutively, 1 lower case, 1 upper case, 1 special char, no white space 
    
            public static bool CheckPassword(string pass)
            {
                //min 6 chars, max 12 chars
                if (pass.Length < 6 || pass.Length > 12)
                    return false;

                //No white space
                if (pass.ToLower().Contains(" "))
                    return false;

                //At least 1 upper case letter
                if (!pass.Any(char.IsUpper))
                    return false;

                //At least 1 lower case letter
                if (!pass.Any(char.IsLower))
                    return false;

                //No two similar chars consecutively
                for (int i = 0; i < pass.Length - 1; i++)
                {
                    if (pass[i] == pass[i + 1])
                        return false;
                }
                //At least 1 special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";

                char[] specialCharactersArray = specialCharacters.ToCharArray();
            var res = specialCharactersArray.Select(c => pass.Contains(c));
                foreach (char c in specialCharactersArray)
                {
                    if (pass.Contains(c))
                        return true;
                }
                return false;
            }
        
        public static string SimplePassword(string str)
        {
            // check the length of the password if its length is not within 8-30 range return false
            //if it contains word "password" return false
            //if it doesnt contain any upper case leter return false
            //if it doesnt contain a digit return false
            ////if it doesnt contain any punctuation mark return false
            //otherwise return true

            //Define a list of punctuation Marks
            string punctuationMarks = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] punctuationMarksArray = punctuationMarks.ToCharArray();

            if (str.Length <= 7 || str.Length >= 31)
                return "false";
            else if (str.ToLower().Contains("password"))
                return "false";
            else if (str.Contains(" "))
                return "false";
            else if (!str.Any(char.IsUpper))
                return "false";
            else if (!str.Any(char.IsNumber))
                return "false";
            else if (!punctuationMarksArray.Any(c => str.Contains(c)))
                return "false";
            else
                return "true";
        }
    }
    }


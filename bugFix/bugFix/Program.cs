using System;

class MainClass
{
    public static string MissingDigitII(string str)
    {
        int slot1 = str.IndexOf("?");
        int slot2 = str.LastIndexOf("?");
        
        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                string[] strArr = new string[str.Length];

                for (int k = 0; k < str.Length; k++)
                    strArr[k] = str[k].ToString();

                strArr[slot1] = i.ToString();
                strArr[slot2] = j.ToString();

                strArr = string.Join("", strArr).Split(" ");
                int num1 = int.Parse(strArr[0]);
                int num2 = int.Parse(strArr[2]);
                int answer = int.Parse(strArr[4]);

                int equastion = determineSign(strArr[1], num1, num2);
                if (equastion == answer)
                    return i + " " + j;
            }
        }
        return "";
    }
    public static int determineSign(string str, int num1, int num2)
    {
        if (str == "+")
            return (num1 + num2);
        if (str == "-")
            return (num1 - num2);
        if (str == "*")
            return (num1 * num2);
        if (str == "/")
            return (num1 / num2);

        return 0;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(MissingDigitII("38?5 * 3 = 1?595"));
        Console.WriteLine(MissingDigitII("56? * 106 = 5?678"));
        Console.WriteLine(MissingDigitII("18?1 + 9 = 189?"));
    }
}
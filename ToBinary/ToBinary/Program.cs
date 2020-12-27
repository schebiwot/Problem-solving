using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine(ToBinarie(5));
    }
    public static string ToBinarie(int num)
    {
        string result = Convert.ToString(num, 2);
        return result;

    }
}
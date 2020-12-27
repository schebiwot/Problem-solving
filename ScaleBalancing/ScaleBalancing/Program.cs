using System;
using System.Linq;

namespace ScaleBalancing
{
    /*
     * Scale Balancing
HIDE QUESTION
Have the function ScaleBalancing(strArr) read strArr which will contain two elements, the first being the two positive integer weights on a balance scale (left and right sides) and the second element being a list of available weights as positive integers. Your goal is to determine if you can balance the scale by using the least amount of weights from the list, but using at most only 2 weights. For example: if strArr is ["[5, 9]", "[1, 2, 6, 7]"] then this means there is a balance scale with a weight of 5 on the left side and 9 on the right side. It is in fact possible to balance this scale by adding a 6 to the left side from the list of weights and adding a 2 to the right side. Both scales will now equal 11 and they are perfectly balanced. Your program should return a comma separated string of the weights that were used from the list in ascending order, so for this example your program should return the string 2,6

There will only ever be one unique solution and the list of available weights will not be empty. It is also possible to add two weights to only one side of the scale to balance it. If it is not possible to balance the scale then your program should return the string not possible.

Use the Parameter Testing feature in the box below to test your code with different arguments.
     */
    /*
     1. For input new string[] {"[5, 9]", "[1, 2, 6, 7]"} the output was incorrect. The correct output is 2,6

2. For input new string[] {"[3, 7]", "[1, 2, 7]"} the output was incorrect. The correct output is not possible

3. For input new string[] {"[13, 4]", "[1, 2, 3, 6, 14]"} the output was incorrect. The correct output is 3,6

4. For input new string[] {"[13, 4]", "[1, 2, 3, 3, 4]"} the output was incorrect. The correct output is not possible

5. For input new string[] {"[1, 2]", "[1, 1, 1, 1]"} the output was incorrect. The correct output is 1

6. For input new string[] {"[3, 4]", "[1, 2, 7]"} the output was incorrect. The correct output is 1

7. For input new string[] {"[6, 2]", "[1, 10, 6, 5]"} the output was incorrect. The correct output is 1,5

8. For input new string[] {"[6, 1]", "[1, 10, 6, 5]"} the output was incorrect. The correct output is 5

9. For input new string[] {"[1, 100]", "[1, 2, 3, 4, 5, 89, 99]"} the output was incorrect. The correct output is 99

10. For input new string[] {"[12, 7]", "[1, 16, 5, 8, 10]"} the output was incorrect. The correct output is 5*/
    class Program
    {

        public static string ScaleBalancing(string[] strArr)
        {
            //Extract Leftand Right Elements in array
            //Find the difference between elements in weightsToBalance
            //Get elements in weightList that sums up to difference
            //strArr.Replace("[", "").Replace("]", "")

            //string weightsToBalance = strArr[0];
            //string weightList = strArr[1];

            //var cleanWeightsToBalance = weightsToBalance.Replace("[", "").Replace("]", "").ToArray();

            //foreach (var i in cleanWeightsToBalance)
            //{
            //    Console.WriteLine(i);
            //}

            // code goes here  
            strArr.ToCharArray.Split("[");
            string delimeters = ('"', '[', ']', '"');
            return strArr[0];

        }

        static void Main(string[] args)
        {
            string[] arr= new string[] { "[5, 9]", "[1, 2, 6, 7]" };
            Console.WriteLine(ScaleBalancing(arr));
        }
    }
   }

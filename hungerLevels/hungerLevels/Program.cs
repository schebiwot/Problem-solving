using System;

using System.Collections.Generic;

namespace hungerLevels
{
    class Program
    {
        //{5,3,1,2,1}->distribution {2,0,1,0}->{1,1,1,1}6

        //sorted 11235
        static void Main(string[] args)
        {
            int[] test = {3,5,2,3,1,0};

           findDistribution(test);
        }
        
        public static  int [] findDistribution(int [] hunger)
        {
           List <int> distribution =new List <int>();
            //save new hunger levels in the distribution
            //check if the sandwiches

            HashSet<int> hs = new HashSet <int> (hunger);
            int diff = 0;

            for (int i = 1; i < hs.Count ; i+=2)
            {
                if (hunger[i] > hunger[i+1 ] )
                {
                    diff = hunger[i] - hunger[i + 1];
                    hunger[i]=hunger[i]-diff;
                    distribution.Add(diff);
                    
                }

                else if(hunger[i+1] > hunger[i])
                {
                    diff = hunger[i + 1] - hunger[i];
                    distribution.Add(hunger[i + 1]);
                    distribution.Add(diff);
                   
                }
                else if (!hs.Contains(hunger[i+1]))
                {
                    diff = hunger[i];
                }


                else
                {
                    diff=0;
                    distribution.Add(diff);
                }

            }
            //distribution.ToArray();
           
            
           Console.WriteLine(string.Join(",",distribution));
            //Console.WriteLine(string.Join(",", newHunger));
            return new int[] { 111, 3, 4 };
        }

        // create a list, add array items to the list,remove the first element from the list
      
        //find the maximum number in the list
        //find the second maximum number in list
        //


        //find the sum of the difference the pairs

}
}
using System;

namespace StudentsCourse
{
    class Program
    {
        
        static void Main(string[] args)
        {  //Array of two rows
            int[,] Scores= new int[4, 3] { { 90, 70, 43 }, 
                                           { 24, 56, 76 }, 
                                           { 34, 68, 100 },
                                           { 90, 87, 44 }
                                        };
            //row represents students
            //column represents marks
           // Console.WriteLine(Scores[3,1]);
            //Console.WriteLine(Scores.Length);
            //Console.WriteLine(Scores.GetLength(0));
           // Console.WriteLine(Scores.GetLength(1));

            //int Total = 0;

            int i = 1;


            //while (i<Scores.GetLength(0))
            //{

               
               

                for (int j = 0; j < Scores.GetLength(1); j++)
                {

                Console.WriteLine(Scores[i,j]);
            }



        }
    }
}

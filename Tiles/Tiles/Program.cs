using System;

namespace Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findMaximumTilesToFormSquare(13,3));
            Console.WriteLine(findMaximumTilesToFormSquare(0,18));
        }
        public static int findMaximumTilesToFormSquare(int M,int N)
        {
            int count = 0;

            int mtiles = (int)Math.Sqrt(M);
            int ntiles =(int) Math.Sqrt(N);
            Console.WriteLine(ntiles + ",,,,,"+mtiles);

            count = mtiles + ntiles * 2;

            //n sqareroot and multiply by 2
            //squareroot 

            return count;
        }
    }
}

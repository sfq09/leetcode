using System;

namespace ArrayTutorial
{
    class Program
    {

        
         
        static void Main(string[] args)
        {
            //Call ALL OTHER PROGRAMS
            //Console.WriteLine(NewClass.a.ToString());
            //DVDThings.Callfunc();
            //Console.WriteLine(MaxConsecutiveOnes.FindMaxConsecutiveOnes(new int[] { 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0 }));
            //Console.WriteLine(NumberswithEvenNumberofDigits.FindNumbers(new int[] { 0, 11, 1, 1, 0, 1, 1, 1, 1, 1, 0 }));
            foreach( var n in SquaresOfaSortedArray.SortedSquares(new int[] { -3, -2, 4 })) Console.WriteLine(" "+n);
            Console.ReadKey();
        }

        //Just a inner class experiment
        public static class InnerClass
        {
            public static  readonly int a = 10;
        }
        
    }

    class NewClass
    {
        public static readonly int a = Program.InnerClass.a;
    }


}

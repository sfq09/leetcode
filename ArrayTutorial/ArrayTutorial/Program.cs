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
            //foreach( var n in SquaresOfaSortedArray.SortedSquares(new int[] { -3, -2, 4 })) Console.WriteLine(" "+n);
            // foreach (var n in DuplicateZeros.GetDuplicateZeros(new int[] { 0, 11, 1, 1, 0, 1, 1, 1, 1, 1, 0 }))   Console.Write(" " + n);
            // foreach (var n in DuplicateZeros.GetInPlaceDuplicateZeros(new int[] {1, 0, 2, 3, 0, 4, 5, 0}))   Console.Write(" " + n);
            //foreach (var n in      MergeSortedArray.GetMergeSortedArray(new int[] { 0,1, 2, 3, 5, 0, 0, 0 },5, new int[] { 4,5,6 }, 3 )) Console.Write(" " + n);
            //foreach (var n in    RemoveElement.RemoveElementFromArray(new int[] { 0,1, 2, 3, 5, 0, 0, 0 },0)) Console.Write(" " + n);
            //Console.WriteLine(CheckIfNandItsDoubleExist.CheckIfNandItsDoubleExists(new int[] {-2, 0, 10, -19, 4, 6, -8 }).ToString());
            //Console.WriteLine(ValidMountainArray.CheckValidMountainArray(new int[] { -2, 0, 10, 9 }).ToString());
            // foreach (var n in ReplaceElementswithGreatestElementonRightSide.ReplaceElements(new int[] { 0,1, 2, 3, 5, 0, 0, 0 })) Console.Write(" " + n);
            //Console.WriteLine(RemoveElement.RemoveDuplicates(new int[] { 1}).ToString()); // Console.Write(" " + n);
            //foreach (var n in MoveZeroes.DoMoveZeros(new int[] { 0,1, 2, 3, 5, 0, 0, 0 })) Console.Write(" " + n);
            // foreach (var n in SortArrayByParity.DoSortArrayByParity(new int[] { 0, 1, 2, 3, 5, 0, 0, 0 })) Console.Write(" " + n);
            foreach (var n in RemoveElement.RemoveElementImproved(new int[] { 0, 1, 2, 3, 5, 0, 0, 0 },0)) Console.Write(" " + n);

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

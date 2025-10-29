// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check whether the square is magic or not.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   const int row = 3;

   static void Main (string[] args) {
      for (; ; ) {
         Write ("Enter the elements of list row-wise: ");
         var input = ReadLine ();
         if (int.TryParse (input, out int num) && input.Length < 10) {
            WriteLine ($"The Square is {(IsMagicSquare (num) ? "" : "not ")}magic");
         } else WriteLine ("Enter a valid num!!");
      }
   }

   static bool IsMagicSquare (int num) {
      int[] row1 = new int[row];
      int[] row2 = new int[row];
      int[] row3 = new int[row];
      List<int[]> intArrList = [row1, row2, row3];
      foreach (var r in intArrList) {
         for (int i = 0; i < row; i++) {
            r[i] = num % 10;
            num = num / 10;
         }
      }
      int sum = row1[0] + row1[1] + row1[2];
      return (row2[0] + row2[1] + row2[2] == sum
           && row3[0] + row3[1] + row3[2] == sum
           && row1[0] + row2[0] + row3[0] == sum
           && row1[1] + row2[1] + row3[1] == sum
           && row1[2] + row2[2] + row3[2] == sum
           && row1[0] + row2[1] + row3[2] == sum
           && row1[2] + row2[1] + row3[0] == sum);
   }
}
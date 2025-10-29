// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      for (; ; ) {
         Write ("Enter a num: ");
         var input = ReadLine ();
         if (int.TryParse (input, out int num)) {
            WriteLine ($"Result: {DigitSorter (num)}");
         } else WriteLine ("Enter a valid num!!");
      }
   }

   static int DigitSorter (int num) {
      List<int> odds = [];
      List<int> evens = [];
      while (num > 0) {
         int digit = num % 10;
         num /= 10;
         if (digit % 2 == 0) {
            evens.Add (digit);
         } else odds.Add (digit);
      }
      odds.Sort ();
      evens.Sort ();
      int sNum = 0;
      for (int i = 0; i < evens.Count; i++) {
         sNum = sNum * 10 + evens[i];
      }
      for (int i = 0; i < odds.Count; i++) {
         sNum = sNum * 10 + odds[i];
      }
      return sNum;
   }
}
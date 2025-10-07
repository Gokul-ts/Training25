// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program takes only character input from user and prompts the user for a special character 
// and order for sorting. If nothing is entered ascending order is taken as default. Prints the 
// sorted array with special character at the end.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Write ("Enter the character array: ");
         var inpArr = ReadLine ();
         Write ("Enter special character: ");
         var spChar = ReadKey ().KeyChar;
         Write ("\nEnter [A]scending or [D]escending: ");
         var order = ReadKey ().Key;
         WriteLine ((!string.IsNullOrEmpty (inpArr) && inpArr.All (char.IsLetter) && char.IsLetter (spChar) &&
            order is ConsoleKey.D or ConsoleKey.A or ConsoleKey.Enter) ?
            $"\nSorted array: {SortAndSwap (inpArr, spChar, order)}" :
            "\nPlease enter a valid input!!");
      }

      /// <summary>Returns the sorted array with special character at the end.</summary>
      string SortAndSwap (string inpArr, char spChar, ConsoleKey order) {
         var spChars = inpArr.Where (a => a == char.ToUpper (spChar) || a == char.ToLower (spChar));
         var sortArr = inpArr.Where (a => !spChars.Contains (a));
         sortArr = order is ConsoleKey.D ? sortArr.OrderDescending () : sortArr.Order ();
         sortArr = sortArr.Concat (spChars.Any () ? spChars : Enumerable.Empty<char> ());
         return string.Concat (sortArr);
      }
   }
}
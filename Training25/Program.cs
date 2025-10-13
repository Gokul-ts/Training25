// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to reduce a string of lowercase characters by deleting a pair of adjacent letters that match.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Write ("Enter a string input: ");
         var input = ReadLine ()?.Trim ();
         WriteLine (!string.IsNullOrEmpty (input) && input.All (char.IsLower) ?
            $"Output: {ReducedString (input)}" :
            "Please enter a valid input!!");
      }
   }

   /// <summary>Removes adjacent pair of lowercase letters from a string.</summary>
   static string ReducedString (string input) {
      Span<char> span = input.ToCharArray ();
      int j = 0;
      for (int i = 0; i < span.Length; i++)
         if (j > 0 && span[j - 1] == span[i])
            j--;
         else
            span[j++] = span[i];
      return j == 0 ? "Empty string" : new string (span.Slice (0, j));
   }
}
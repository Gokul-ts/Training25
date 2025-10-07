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
         var input = ReadLine ()?.ToLower ();
         WriteLine (!string.IsNullOrEmpty (input) && input.All (char.IsLetter) ?
            $"Output: {ReducedString (input)}" :
            "Please enter a valid input!!");
      }

      /// <summary>Removes adjacent pair of lowercase letters from a string.</summary>
      string ReducedString (string input) {
         for (int i = 0; i < input.Length - 1;) {
            if (input[i] == input[i + 1]) input = input.Remove (i, 2);
            else i++;
         }
         return input == "" ? "Empty string" : input;
      }
   }
}
// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print the reverse of a string.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Write ("Enter a string input: ");
         var input = ReadLine ();
         WriteLine (!string.IsNullOrEmpty (input) ?
            $"Reversed string{":",6} {ReverseString (input)}" :
            "Please enter a valid input!!");
      }

      /// <summary>Returns the reverse of a string</summary>
      string ReverseString (string input) {
         ReadOnlySpan<char> span = input;
         int length = span.Length;
         char[] result = new char[length];
         for (int i = 0, revIndex = length - 1; i < length; i++) {
            if (span[i] == ' ') result[i] = ' ';
            else {
               while (revIndex >= 0 && span[revIndex] == ' ') revIndex--;
               char c = span[revIndex--];
               result[i] = char.IsUpper (span[i]) ? char.ToUpper (c) : char.ToLower (c);
            }
         }
         return new string (result);
      }
   }
}
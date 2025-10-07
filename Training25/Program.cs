// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print the reverse of a string.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Write ("Enter a string input: ");
         var input = ReadLine ();
         WriteLine (!string.IsNullOrEmpty (input) ?
            $"Reversed string: {ReverseString (input)}" :
            "Please enter a valid input!!");
      }

      /// <summary>Returns the reverse of a string</summary>
      string ReverseString (string input) {
         var output = new StringBuilder ();
         for (int i = input.Length - 1; i >= 0; i--)
            if (input[i] != ' ') output.Append (input[i]);
         for (int j = 0; j < input.Length; j++) {
            if (input[j] == ' ')
               output.Insert (j, ' ');
            else
               output[j] = char.IsUpper (input[j]) ? char.ToUpper (output[j]) : char.ToLower (output[j]);
         }
         return output.ToString ();
      }
   }
}
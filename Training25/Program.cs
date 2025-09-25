// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print the reverse of a string.
// ------------------------------------------------------------------------------------------------
using System.Text;

namespace Training25;
internal class Program {
   static void Main () {
      ReverseString ();
   }

   /// <summary>Prints the reverse of a string</summary>
   static void ReverseString () {
      for (; ; ) {
         Console.Write ("Enter a string input: ");
         var input = Console.ReadLine ();
         if (!string.IsNullOrEmpty (input)) {
            var output = new StringBuilder ();
            for (int i = input.Length - 1; i >= 0; i--)
               if (input[i] is not ' ') output.Append (input[i]);
            int j = 0;
            foreach (char ch in input) {
               if (ch is ' ') output.Insert (j, ' ');
               else if (char.IsUpper (ch)) output[j] = char.ToUpper (output[j]);
               else if (char.IsLower (ch)) output[j] = char.ToLower (output[j]);
               j++;
            }
            Console.WriteLine ($"Reversed string: {output}");
         } else Console.WriteLine ("Please enter a valid input!!");
      }
   }
}
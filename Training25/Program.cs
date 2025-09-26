// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main () {
      ReducedString ();
   }

   /// <summary>Removes adjacent pair of lowercase letters from a string</summary>
   static void ReducedString () {
      for (; ; ) {
         Console.Write ("Enter a string input: ");
         var input = Console.ReadLine ()?.ToLower ();
         if (!string.IsNullOrEmpty (input) && !input.Any (a => char.IsDigit (a) || a is ' ')) {
            int i = 0;
            while (i < input.Length - 1) {
               if (input[i] == input[i + 1]) input = input.Remove (i, 2);
               else i++;
            }
            Console.WriteLine ($"Output: {(input.Length is 0 ? "Empty string" : input)}");
         } else Console.WriteLine ("Please enter a valid input!!");
      }
   }
}
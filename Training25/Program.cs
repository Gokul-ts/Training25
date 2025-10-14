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
         var input = ReadLine ();
         Write ("Enter special character: ");
         var spChar = ReadKey ().KeyChar;
         Write ("\nEnter [A]scending or [D]escending: ");
         var order = ReadKey ().Key;
         WriteLine (!string.IsNullOrEmpty (input) && input.All (char.IsLetter) && char.IsLetter (spChar) &&
            order is ConsoleKey.D or ConsoleKey.A or ConsoleKey.Enter ?
            $"\nSorted array: {new string (SortAndSwap (input, spChar, order is not ConsoleKey.D))}" :
            "\nPlease enter a valid input!!");
      }
   }

   /// <summary>Outputs sorted array with special character at the end.</summary>
   static char[] SortAndSwap (ReadOnlySpan<char> inpSpan, char spChar, bool isAscending) {
      var (lower, upper) = (char.ToLower (spChar), char.ToUpper (spChar));
      char[] output = new char[inpSpan.Length];
      int index = FilterOrAppend (inpSpan, c => c != lower && c != upper, output); // Filter normal characters
      // Sorts the filtered characters either in ascending or descending order
      Array.Sort (output, 0, index, Comparer<char>.Create ((a, b) => isAscending ? a.CompareTo (b) : b.CompareTo (a)));
      FilterOrAppend (inpSpan, c => c == lower || c == upper, output, index); // Append special characters
      return output;

      // Local function to filter or append characters based on a condition
      int FilterOrAppend (ReadOnlySpan<char> input, Func<char, bool> condition, char[] target, int startIndex = 0) {
         int i = startIndex;
         foreach (char c in input)
            if (condition (c))
               target[i++] = c;
         return i;
      }
   }
}
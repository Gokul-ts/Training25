// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print a sorted array with special characters at the end.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main () => SortAndSwap ();

   /// <summary>Function takes only character input from user and prompts the user for a special character 
   /// and order for sorting. If nothing is entered ascending order is taken as default. Prints the 
   /// sorted array to the console with special character at the end. Special character and input string
   /// are not case sensitive but should not be empty.</summary>
   static void SortAndSwap () {
      for (; ; ) {
         Console.Write ("Enter the character array: ");
         var inpArr = Console.ReadLine ();
         Console.Write ("Enter special character: ");
         var spChar = Console.ReadKey ().KeyChar;
         Console.Write ("\nEnter [A]scending or [D]escending: ");
         var order = Console.ReadKey ().Key;
         if (!string.IsNullOrEmpty (inpArr) && inpArr.All (char.IsLetter) &&
            char.IsLetter (spChar) && order is ConsoleKey.D or ConsoleKey.A or ConsoleKey.Enter) {
            var spChars = inpArr.Where (a => a == char.ToUpper (spChar) || a == char.ToLower (spChar));
            var sortArr = inpArr.Where (a => !spChars.Contains (a));
            sortArr = order is ConsoleKey.D ? sortArr.OrderDescending () : sortArr.Order ();
            sortArr = sortArr.Concat (spChars.Any () ? spChars : Enumerable.Empty<char> ());
            Console.WriteLine ("\nSorted array: " + string.Concat (sortArr));
         } else Console.WriteLine ("\nPlease enter a valid input!!");
      }
   }
}
// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to convert a number into roman numerals and words.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main (string[] args) {
      for (; ; ) {
         Console.Write ("Enter a number between 0 and 3999 or [X] to exit: ");
         string? input = Console.ReadLine ();
         if (input?.ToUpper () == "X") Environment.Exit (0);
         if (int.TryParse (input, out int num) && num is >= 0 and < 4000) {
            for (; ; ) {
               Console.Write ("Do you want to convert it into (W)ords or (R)oman Numbers? : ");
               var choice = Console.ReadKey ().Key;
               if (choice is ConsoleKey.W or ConsoleKey.R) {
                  Console.WriteLine ($"\nNumber: {num}\n" + (choice == ConsoleKey.W ? $"Words: {ToWords (num)}\n" : $"Roman:  {ToRoman (num)}\n"));
                  break;
               } else Console.WriteLine ("\nPlease enter a valid Key!!!");
            }
         } else Console.WriteLine ("Please enter a valid number!!!\n");
      }
   }
   /// <summary>Converts number into words</summary>
   static string ToWords (int num) {
      if (num == 0) return " Zero";
      Dictionary<int, string> eWords = new () {
         [1000] = " Thousand", [100] = " Hundred", [90] = " Ninety", [80] = " Eighty", [70] = " Seventy",
         [60] = " Sixty", [50] = " Fifty", [40] = " Forty", [30] = " thirty", [20] = " Twenty", [19] = " Nineteen",
         [18] = " Eighteen", [17] = " Seventeen", [16] = " Sixteen", [15] = " Fifteen", [14] = " Fourteen",
         [13] = " Thirteen", [12] = " Twelve", [11] = " Eleven", [10] = " Ten", [9] = " Nine", [8] = " Eight",
         [7] = " Seven", [6] = " Six", [5] = " Five", [4] = " Four", [3] = " Three", [2] = " Two", [1] = " One"
      };
      string words = "";
      foreach (var key in eWords.Keys) {
         int temp = num / key; // Holds the multiples
         if (temp > 0) {
            words += (key >= 100 ? eWords[temp] : "") + eWords[key];
            num %= key;
         }
      }
      return words;
   }
   /// <summary>Converts number into roman numerals</summary>
   static string ToRoman (int num) {
      if (num == 0) return "Nil";
      string roman = "";
      Dictionary<int, string> rLetters = new () { { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD" },{ 100, "C" },
         { 90, "XC" }, { 50, "L" }, { 40, "XL" },{ 10, "X" }, { 9, "IX" }, { 5, "V" }, { 4, "IV" }, { 1, "I" } };
      foreach (var key in rLetters.Keys)
         while (num >= key) { roman += rLetters[key]; num -= key; }
      return roman;
   }
}
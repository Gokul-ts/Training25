// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to convert a number into roman numerals and words.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Write ("Enter a number between 0 and 3999 or [X] to exit: ");
         string? input = ReadLine ();
         if (input?.ToUpper () == "X") Environment.Exit (0);
         if (!int.TryParse (input, out int num) || num < 0 || num > 3999) {
            WriteLine ("Please enter a valid number!!!");
            continue;
         }
         WriteLine ($"Number : {num}\nWords  :{ToWords (num)}\nRoman  : {ToRoman (num)}");
      }
   }

   /// <summary>Returns the number in words</summary>
   static string ToWords (int num) {
      if (num == 0) return eWords[0];
      string words = "";
      while (num > 0) {
         switch (num) {
            case >= 1000: words += eWords[num / 1000] + eWords[1000]; num %= 1000; break;
            case >= 100: words += eWords[num / 100] + eWords[100] + (num % 100 > 0 ? " and" : ""); num %= 100; break;
            case >= 20: words += eWords[num / 10 * 10]; num %= 10; break;
            default: words += eWords[num]; num = 0; break;
         }
      }
      return words;
   }

   /// <summary>Returns the number in roman numerals</summary>
   static string ToRoman (int num) {
      if (num == 0) return rLetters[0];
      string roman = "";
      while (num > 0) {
         int value = num switch {
            >= 1000 => (num / 1000) * 1000,
            >= 100 => (num % 1000 / 100) * 100,
            >= 10 => (num % 100 / 10) * 10,
            _ => num % 10
         };
         roman += rLetters[value];
         num -= value;
      }
      return roman;
   }

   static readonly Dictionary<int, string> eWords = new () {
      [1000] = " Thousand", [100] = " Hundred", [90] = " Ninety", [80] = " Eighty", [70] = " Seventy",
      [60] = " Sixty", [50] = " Fifty", [40] = " Forty", [30] = " thirty", [20] = " Twenty", [19] = " Nineteen",
      [18] = " Eighteen", [17] = " Seventeen", [16] = " Sixteen", [15] = " Fifteen", [14] = " Fourteen",
      [13] = " Thirteen", [12] = " Twelve", [11] = " Eleven", [10] = " Ten", [9] = " Nine", [8] = " Eight",
      [7] = " Seven", [6] = " Six", [5] = " Five", [4] = " Four", [3] = " Three", [2] = " Two", [1] = " One", [0] = " Zero"
   };

   static readonly Dictionary<int, string> rLetters = new () {
      [0] = "Nil", [1] = "I", [2] = "II", [3] = "III", [4] = "IV", [5] = "V", [6] = "VI", [7] = "VII", [8] = "VIII", [9] = "IX",
      [10] = "X", [20] = "XX", [30] = "XXX", [40] = "XL", [50] = "L", [60] = "LX", [70] = "LXX", [80] = "LXXX", [90] = "XC",
      [100] = "C", [200] = "CC", [300] = "CCC", [400] = "CD", [500] = "D", [600] = "DC", [700] = "DCC", [800] = "DCCC",
      [900] = "CM", [1000] = "M", [2000] = "MM", [3000] = "MMM"
   };
}
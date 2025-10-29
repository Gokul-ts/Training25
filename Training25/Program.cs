// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program that takes a positive integer and returns its corresponding Excel column name.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      for (; ; ) {
         Write ("Enter a num between (1 and 702): ");
         var input = ReadLine ();
         if (int.TryParse (input, out int num) && num < 703 && num > 0) {
            WriteLine ($"Column name: {NameGenerator (num)}");
         } else WriteLine ("Enter a valid num!!");
      }
   }
   static string NameGenerator (int num) {
      string name = "";
      if (num <= 26) {
         var c = (char)(num + 64);
         name += c;
      }
      if (num > 26 && num <= 702) {
         while (num > 26) {
            int n = num % 26;
            int m = num / 26;
            if (n == 0) {
               var ch = (char)(m - 1 + 64);
               name += ch;
               name += 'Z';
            } else {
               var ch = (char)(m + 64);
               name += ch;
               var c = (char)(n + 64);
               name += c;
            }
            num /= 26;
            if (name.Length == 2) return name;
         }
      }
      return name;
   }
}
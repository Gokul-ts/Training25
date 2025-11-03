// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to find the words that match with input.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      var words = File.ReadAllLines (@"C:\etc\words.txt");
      for (; ; ) {
         Write ("Enter 7 letters starting with significant one: ");
         var input = ReadLine ()?.Trim ();
         if (!string.IsNullOrEmpty (input) && input.All (char.IsLetter) && input.Distinct ().Count () == 7) {
            sSeed = input;
            List<(string word, int score, bool isPangram)> pairs = [];
            foreach (var word in words.Where (IsValid))
               pairs.Add ((word, GetScore (word, out bool isPangram), isPangram));
            int total = 0;
            foreach (var pair in pairs.OrderByDescending (a => a.score).ThenBy (a => a.word)) {
               if (pair.isPangram) ForegroundColor = ConsoleColor.Green;
               WriteLine ($"{pair.score,5}. {pair.word}");
               ResetColor ();
               total += pair.score;
            }
            WriteLine ($"------\n{total,5} Total");
         } else WriteLine ("Please enter a valid input!!");
      }
   }

   static bool IsValid (string word) => word.Length > 4 && word.Contains (sSeed[0]) && word.All (sSeed.Contains);

   static bool IsPangram (string word) => sSeed.All (word.Contains);

   static int GetScore (string word, out bool isPangram) {
      int length = word.Length;
      isPangram = IsPangram (word);
      return (length == 4) ? 1 : isPangram ? length + 7 : length;
   }

   static string sSeed = "";
}
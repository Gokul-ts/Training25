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
   static string seed = "";
   static void Main () {
      var words = File.ReadAllLines (@"C:\etc\words.txt");
      for (; ; ) {
         Write ("Enter 7 letters starting with significant one: ");
         var input = ReadLine ()?.Trim ();
         if (!string.IsNullOrEmpty (input) && input.All (char.IsLetter) && input.Distinct ().Count () == 7) {
            seed = input;
            List<(string word, int score)> pairs = [];
            foreach (var word in words) {
               if (IsValid (word))
                  pairs.Add ((word, GetScore (word)));
            }
            int totalScore = 0;
            foreach (var pair in pairs) {
               if (IsPangram (pair.word))
                  ForegroundColor = ConsoleColor.Green;
               WriteLine ($"{pair.score,5} {pair.word}");
               ResetColor ();
               totalScore += pair.score;
            }
            WriteLine ($"------\n{totalScore,5} Total");
         } else WriteLine ("Please enter a valid input!!");
      }
   }

   static bool IsValid (string word)
      => word.Length > 4 && word.Contains (seed[0]) && word.All (seed.Contains);

   static bool IsPangram (string word)
      => seed.All (word.Contains);

   static int GetScore (string word) {
      int length = word.Length;
      return (length == 4) ? 1 : IsPangram (word) ? length + 7 : length;
   }
}
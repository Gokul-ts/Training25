// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to find the winner of a contest given a string of votes.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Write ("Enter a string: ");
         var input = ReadLine ();
         WriteLine (!string.IsNullOrEmpty (input) && input.All (char.IsLetter) ?
            $"Winner: {FindWinner (input, out int votes)} Votes: {votes}" :
            "Please enter a valid input");
      }

      /// <summary>Returns the winner with maximum number of votes.</summary> 
      static char FindWinner (string input, out int maxVotes) {
         Dictionary<char, int> voteData = new ();
         string votes = input.ToUpper ();
         foreach (char c in votes)
            if (voteData.ContainsKey (c)) voteData[c]++;
            else voteData[c] = 1;
         int max = voteData.Values.Max ();
         var winners = voteData.Where (a => a.Value == max);
         maxVotes = max;
         return winners.First ().Key;
      }
   }
}
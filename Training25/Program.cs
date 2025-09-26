// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to find the winner of a contest given a string of votes.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main () {
      FindWinner ();
   }

   /// <summary>Prints the winner of a contest with the maximum number of votes 
   /// or the first one to get max. votes if results are tied</summary>
   static void FindWinner () {
      for (; ; ) {
         Console.Write ("Enter a string: ");
         var input = Console.ReadLine ();
         if (!string.IsNullOrEmpty (input) && input.All (char.IsLetter)) {
            Dictionary<char, int> voteData = new ();
            string votes = input.ToUpper ();
            foreach (char c in votes)
               if (voteData.Keys.Contains (c)) voteData[c]++;
               else voteData.Add (c, 1);
            var winners = voteData.Where (a => a.Value == voteData.Values.Max ());
            Console.WriteLine ($"Winner: {winners.First ().Key} Votes: {winners.First ().Value}");
         } else Console.WriteLine ("Please enter a valid input");
      }
   }
}
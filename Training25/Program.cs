// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("*****Number guessing game*****\n");
      int rNum = new System.Random ().Next (1, 101);
      GuessNumber (rNum);
   }
   static void GuessNumber (int rNum) {
      int attempts = 0;
      for (; ; ) {
         Console.Write ("Enter a number between 1-100: ");
         string? guess = Console.ReadLine ();
         if (guess != null) {
            attempts++;
            if (int.TryParse (guess, out int inputNum)) {
               if (inputNum is < 1 or > 100) {
                  Console.WriteLine ("Please enter between 1 and 100!!!");
                  continue;
               }
               if (inputNum != rNum)
                  Console.WriteLine ($"Your guess is {(inputNum < rNum ? "lower" : "higher")}");
               else {
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine ("Your guess is correct");
                  Console.ResetColor ();
                  break;
               }
            } else Console.WriteLine ("Please enter a valid number!!!");
         } else { Console.WriteLine ("\nFailed to read input"); break; }
      }
      Console.WriteLine ($"Attempts taken: {attempts}");
   }
}
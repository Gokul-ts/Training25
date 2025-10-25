// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      for (; ; ) {
         var mode = GetMode ();
         int max = GetMax (mode);
         int secretNum = new Random ().Next (1, max + 1);
         WriteLine ($"Guess a number between 1 and {max}: ");
         for (; ; ) {
            Write ("> ");
            var input = ReadLine ();
            if (!int.TryParse (input, out int num) || num <= 0 || num > max) {
               WriteLine ("Enter a valid number!!");
               continue;
            }
            Guess guess = GuessNum (num, secretNum);
            WriteLine ($"Your guess is {guess}");
            if (guess == Guess.Correct) break;
         }
      }
   }

   enum Mode { Easy, Medium, Hard }
   enum Guess { Low, High, Correct }

   static Guess GuessNum (int num, int secretNum) {
      if (num < secretNum) return Guess.Low;
      if (num > secretNum) return Guess.High;
      return Guess.Correct;
   }

   static int GetMax (Mode mode) {
      return mode switch {
         Mode.Easy => 10,
         Mode.Medium => 100,
         _ => 1000,
      };
   }

   static Mode GetMode () {
      WriteLine ("Enter mode [E]asy, [M]edium, [H]ard: ");
      for (; ; ) {
         var key = ReadKey (true).Key;
         if (key == ConsoleKey.E) return Mode.Easy;
         if (key == ConsoleKey.M) return Mode.Medium;
         if (key == ConsoleKey.H) return Mode.Hard;
      }
   }
}
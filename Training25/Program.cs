// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to guess a random number between a range.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      for (; ; ) {
         int max = GetMax (GetMode ());
         int secretNum = new Random ().Next (1, max + 1);
         WriteLine ($"Guess a number between 1 and {max}: ");
         for (; ; ) {
            Write ("> ");
            if (!int.TryParse (ReadLine (), out int num) || num <= 0 || num > max) {
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
      return num switch {
         _ when num < secretNum => Guess.Low,
         _ when num > secretNum => Guess.High,
         _ => Guess.Correct,
      };
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
      var key = ReadKey (true).Key;
      return key switch {
         ConsoleKey.E => Mode.Easy,
         ConsoleKey.M => Mode.Medium,
         ConsoleKey.H => Mode.Hard,
         _ => GetMode (),
      };
   }
}
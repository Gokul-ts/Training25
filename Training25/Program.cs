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
   static void Main () {
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
            EGuess guess = GuessNum (num, secretNum);
            WriteLine ($"Your guess is {guess}");
            if (guess == EGuess.Correct) break;
         }
      }
   }

   static EGuess GuessNum (int num, int secretNum)
      => num switch {
         _ when num < secretNum => EGuess.Low,
         _ when num > secretNum => EGuess.High,
         _ => EGuess.Correct,
      };

   static int GetMax (EMode mode)
     => mode switch {
        EMode.Easy => 10,
        EMode.Medium => 100,
        _ => 1000,
     };


   static EMode GetMode () {
      WriteLine ("Enter mode [E]asy, [M]edium, [H]ard: ");
      var key = ReadKey (true).Key;
      return key switch {
         ConsoleKey.E => EMode.Easy,
         ConsoleKey.M => EMode.Medium,
         ConsoleKey.H => EMode.Hard,
         _ => GetMode (),
      };
   }

   enum EMode { Easy, Medium, Hard }
   enum EGuess { Low, High, Correct }
}
// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to calculate the smallest number of steps to transform a number.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      for (; ; ) {
         Write ("Enter a number: ");
         var input = ReadLine ();
         WriteLine (int.TryParse (input, out int num) && num > 0 ?
            $"Minimum steps to transform: {Transform (num)}" :
            "Please enter a valid number!!");
      }

      /// <summary>Returns the minimum no. of steps required to transform an integer.</summary>
      int Transform (int num) {
         int minSteps = int.MaxValue;
         var digits = num.ToString ().Distinct ().Select (c => c - '0').ToList ();
         foreach (int target in digits) {
            int temp = num, steps = 0;
            for (; temp > 0; temp /= 10) {
               int digit = temp % 10;
               steps += digit > target ? digit - target : target - digit;
            }
            if (steps < minSteps) minSteps = steps;
         }
         return minSteps;
      }
   }
}
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
   static void Main () {
      for (; ; ) {
         Write ("Enter a number: ");
         WriteLine (int.TryParse (ReadLine (), out int num) && num > 0 ?
            $"Minimum steps : {Transform (num, out long targetNum)}\nTransformed Number: {targetNum}" :
            "Please enter a valid number!!");
      }
   }

   /// <summary>Returns the minimum no. of steps and the transformed number.</summary>
   static int Transform (int num, out long bestTarget) {
      int minSteps = int.MaxValue;
      bestTarget = 0;
      List<int> digits = [];
      for (int temp = num; temp > 0; temp /= 10)
         digits.Add (temp % 10);
      foreach (int target in digits.Distinct ()) {
         int steps = digits.Sum (d => Math.Abs (d - target));
         if (steps < minSteps) {
            minSteps = steps;
            bestTarget = target;
         }
      }
      // long is used here to handle edge cases where int overflows
      bestTarget = long.Parse (string.Concat (Enumerable.Repeat (bestTarget, digits.Count)));
      return minSteps;
   }
}
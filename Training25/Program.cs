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
      int minSteps = int.MaxValue, count = 0;
      bestTarget = 0;
      HashSet<int> digits = [];
      for (int temp = num; temp > 0; temp /= 10) {
         digits.Add (temp % 10);
         count++;
      }
      foreach (int target in digits) {
         int temp = num, steps = 0;
         for (; temp > 0; temp /= 10) {
            int digit = temp % 10;
            steps += Math.Abs (digit - target);
         }
         if (steps < minSteps) bestTarget = target;
         minSteps = Math.Min (steps, minSteps);
      }
      // long is used here to handle edge cases where int overflows
      for (int i = 0; i < count - 1; i++)
         bestTarget = bestTarget * 10 + bestTarget % 10;
      return minSteps;
   }
}
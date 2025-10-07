// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check Armstrong number.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Write ("Enter a number: ");
         var input = ReadLine ();
         WriteLine (int.TryParse (input, out int num) && (num >= 0) ?
            $"It is {(IsArmstrong (num) ? "" : "not ")}an Armstrong number" :
            "Please enter a valid number!!");
      }

      /// <summary>Returns whether the number is Armstrong or not </summary>
      bool IsArmstrong (int num) {
         double sum = 0, org = num, pow = num.ToString ().Length;
         while (num > 0) {
            sum += Math.Pow (num % 10, pow);
            num /= 10;
         }
         return sum == org;
      }
   }
}
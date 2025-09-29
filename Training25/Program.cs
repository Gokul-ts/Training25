// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to calculate the smallest number of steps to transform a number.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main (string[] args) => Transform ();

   /// <summary>Takes only integer input from user and filters out the distinct elements.
   /// Returns the minimum no. of steps required to transform the integer into identical digits.</summary>
   static void Transform () {
      //for (; ; ) {
      //   Console.Write ("Enter a number: ");
      //   var input = Console.ReadLine ();
      //   if (int.TryParse (input, out int num) && num > 0) {
      //      int minSteps = int.MaxValue;
      //      var digits = input.Distinct ().Select (c => c - '0').ToList ();
      //      foreach (int target in digits) {
      //         int temp = num, steps = 0;
      //         while (temp > 0) {
      //            int digit = temp % 10;
      //            steps += digit > target ? digit - target : target - digit;
      //            temp /= 10;
      //         }
      //         if (steps < minSteps) minSteps = steps;
      //      }
      //      Console.WriteLine ($"Minimum steps to transform: {minSteps}\n");
      //   } else Console.WriteLine ("Please enter a valid number!!\n");
      //}

      /// <summary>
      /// Returns the minimum number of steps to transform an integer into a number with all identical digits.
      /// A step is incrementing or decrementing a digit by one.
      /// </summary>
      Console.Write ("Enter a number: ");
      if (int.TryParse (Console.ReadLine (), out int num) && num > 0) {
         int steps = MinStepsToIdenticalDigits (num);
         Console.WriteLine ($"Minimum steps to transform: {steps}");
      } else {
         Console.WriteLine ("Please enter a valid number!");
      }
      int MinStepsToIdenticalDigits (int num) {
         if (num <= 0) return 0;
         var digits = num.ToString ().Select (c => c - '0').ToList ();
         int minSteps = int.MaxValue;
         // Try making all digits equal to each possible digit (0-9)
         for (int target = 0; target <= 9; target++) {
            int steps = digits.Sum (d => Math.Abs (d - target));
            if (steps < minSteps) minSteps = steps;
         }
         return minSteps;
      }
   }
}
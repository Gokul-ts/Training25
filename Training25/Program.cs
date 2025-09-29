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
      for (; ; ) {
         Console.Write ("Enter a number: ");
         var input = Console.ReadLine ();
         if (int.TryParse (input, out int num) && num > 0) {
            int minSteps = int.MaxValue;
            var digits = input.Distinct ().Select (c => c - '0').ToList ();
            foreach (int target in digits) {
               int temp = num, steps = 0;
               while (temp > 0) {
                  int digit = temp % 10;
                  steps += digit > target ? digit - target : target - digit;
                  temp /= 10;
               }
               if (steps < minSteps) minSteps = steps;
            }
            Console.WriteLine ($"Minimum steps to transform: {minSteps}\n");
         } else Console.WriteLine ("Please enter a valid number!!\n");
      }
   }
}
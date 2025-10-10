// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print the nth Armstrong number.
// ------------------------------------------------------------------------------------------------
using System; //Required to run program in terminal
using static System.Console;

namespace Training25;
internal class Program {
   static void Main (string[] args) {
      var input = "";
      if (args.Length == 0) {
         Write ("Enter a number between 1 and 25: ");
         input = ReadLine ();
      } else input = args[0];
      WriteLine (int.TryParse (input, out int num) && num >= 0 && num <= 25 ?
         $"Armstrong num: {NthArmstrong (num)}" :
         "Please enter a valid number!!");
   }

   /// <summary>Returns whether a number is Armstrong or not</summary>
   static bool IsArmstrong (int num) {
      double sum = 0, org = num, pow = 0;
      for (int temp = num; temp > 0; temp /= 10) pow++;
      while (num > 0) {
         sum += Math.Pow (num % 10, pow);
         num /= 10;
      }
      return sum == org;
   }

   /// <summary>Returns the nth Armstrong number</summary>
   static int NthArmstrong (int n) {
      int count = 0, num = 0;
      while (count < n) {
         if (IsArmstrong (num)) count++;
         num++;
      }
      return --num;
   }
}
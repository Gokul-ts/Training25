// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to calculate the LCM and GCD of two numbers.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main () {
      Calculate ();
   }

   /// <summary>Calculates the LCM and GCD of two numbers</summary>
   static void Calculate () {
      for (; ; ) {
         Console.Write ("Enter two non-zero integers\nnum1: ");
         string? input1 = Console.ReadLine ();
         Console.Write ("num2: ");
         string? input2 = Console.ReadLine ();
         Console.WriteLine (int.TryParse (input1, out int num1) && int.TryParse (input2, out int num2)
            && num1 > 0 && num2 > 0 ? $"LCM:  {LCM (num1, num2)}\nGCD:  {GCD (num1, num2)}\n" :
            "Please enter a valid input!!!\n");
      }

      /// <summary>Returns the GCD of two numbers</summary>
      int GCD (int num1, int num2) {
         while (num2 != 0) {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
         }
         return num1;
      }

      /// <summary>Returns the LCM of two numbers</summary>
      int LCM (int num1, int num2) => num1 * num2 / GCD (num1, num2);
   }
}
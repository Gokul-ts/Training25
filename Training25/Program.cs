// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check Armstrong number.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main () {
      CheckNum ();
   }

   /// <summary>Checks whether number is Armstrong or not </summary>
   static void CheckNum () {
      for (; ; ) {
         Console.Write ("Enter a number: ");
         var input = Console.ReadLine ();
         if (int.TryParse (input, out int num) && num >= 0) {
            Console.WriteLine ($"It is {(IsArmstrong (num) ? "" : "not ")}an Armstrong number");
         } else Console.WriteLine ("Please enter a valid number!!");
      }

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
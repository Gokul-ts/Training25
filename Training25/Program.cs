// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print digital root of a number.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main (string[] args) {
      for (; ; ) {
         Console.Write ("Enter a positive integer: ");
         string? input = Console.ReadLine ();
         if (int.TryParse (input, out int num) && num > 0)
            Console.WriteLine ($"Input: {input}\nDigitalRoot: {DigitalRoot (num)}\n");
         else
            Console.WriteLine ("Please enter a valid number!!!\n");
      }
   }
   /// <summary>Returns the digital root of a number</summary>
   static int DigitalRoot (int num) {
      while (num > 9) {
         int sum = 0;
         while (num > 0) {
            sum += num % 10;
            num /= 10;
         }
         num = sum;
      }
      return num;
   }
}
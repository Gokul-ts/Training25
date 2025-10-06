// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to convert a decimal into binary and hexadecimal.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Console.Write ("Enter a number or [X] to exit: ");
         var input = Console.ReadLine ();
         if (input?.ToUpper () == "X") Environment.Exit (0);
         Console.WriteLine (int.TryParse (input, out int num) && num >= 0 ?
         $"Input: {num}\nHEX: {num:X}\nBinary: {Binary (num)}" :
         "Please enter a valid input!!!");
      }

      /// <summary>Returns the binary value of a number</summary>
      string Binary (int num) {
         string result = num is 0 ? "0" : string.Empty;
         for (; num > 0; num /= 2) result = (num % 2) + result;
         return result;
      }
   }
}
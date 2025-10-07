// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to convert a decimal into binary and hexadecimal.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Write ("Enter a number or [X] to exit: ");
         var input = ReadLine ();
         if (input?.ToUpper () == "X") Environment.Exit (0);
         WriteLine (int.TryParse (input, out int num) && (num >= 0) ?
            $"Input: {num}\nHEX: {Hex (num)}\nBinary: {Binary (num)}" :
            "Please enter a valid input!!!");
      }

      /// <summary>Returns the binary value of a number</summary>
      string Binary (int num) {
         string result = num is 0 ? "0" : string.Empty;
         for (; num > 0; num /= 2) result = $"{num % 2}{result}";
         return result;
      }

      /// <summary>Returns the hexadecimal value of a number</summary>
      string Hex (int num) {
         string hex = "0123456789ABCDEF", result = string.Empty;
         for (; num > 0; num /= 16) result = $"{hex[num % 16]}{result}";
         return result is "" ? "0" : result;
      }
   }
}
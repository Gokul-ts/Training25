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
         Console.WriteLine (int.TryParse (input, out int num) ?
         $"Input: {num}\nHEX: {num:X}\nBinary: {Convert.ToString (num, 2)}" :
         "Please enter a valid input!!!");
      }
   }
}
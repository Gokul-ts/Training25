// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to validate a password.
// ------------------------------------------------------------------------------------------------
using System.Text;
namespace Training25;
internal class Program {
   static void Main () {
      CheckValidity ();
   }

   /// <summary>Checks the validity of password and prints result</summary>
   static void CheckValidity () {
      for (; ; ) {
         Console.Write ("Enter password: ");
         var input = Console.ReadLine ();
         if (string.IsNullOrEmpty (input) || input.Any (a => a == ' ')) {
            Console.WriteLine ("Please enter a valid password!!!\n");
            continue;
         }
         Console.ForegroundColor = ConsoleColor.DarkRed;
         var result = new StringBuilder ("Your password is weak.\nIt should have atleast");
         string spChars = "!@#$%^&*()-+";
         bool isStrong = true;
         if (input.Length >= 6) {
            if (!input.Any (a => char.IsDigit (a))) { result.Append (" 1 digit"); isStrong = false; }
            if (!input.Any (a => char.IsUpper (a))) { result.Append (" 1 upper case"); isStrong = false; }
            if (!input.Any (a => char.IsLower (a))) { result.Append (" 1 lower case"); isStrong = false; }
            if (!spChars.Any (a => input.Contains (a))) { result.Append (" 1 special character"); isStrong = false; }
         } else { result.Append (" 6 characters"); isStrong = false; }
         if (isStrong) {
            Console.ForegroundColor = ConsoleColor.Green;
            result.Clear ();
            result.Append ("Your password is strong");
         }
         Console.WriteLine (result + "\n");
         Console.ResetColor ();
      }
   }
}
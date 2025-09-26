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
      ValidatePassword ();
   }

   /// <summary>Checks the validity of password and prints the result. The password should 
   /// have atleast 1 digit, 1 uppercase, 1 lowercase, 1 special character and 6 characters. 
   /// If it satisfies all criteria the password is strong else weak.</summary>
   static void ValidatePassword () {
      for (; ; ) {
         Console.Write ("Enter password: ");
         var input = Console.ReadLine ();
         if (string.IsNullOrEmpty (input) || input.Any (a => a is ' ')) {
            Console.WriteLine ("Please enter a valid password!!!\n");
            continue;
         }
         Console.ForegroundColor = ConsoleColor.DarkRed;
         var result = new StringBuilder ();
         string spChars = "!@#$%^&*()-+";
         if (input.Length >= 6) {
            if (!input.Any (char.IsDigit)) result.Append (" 1 digit");
            if (!input.Any (char.IsUpper)) result.Append (" 1 upper case");
            if (!input.Any (char.IsLower)) result.Append (" 1 lower case");
            if (!spChars.Any (input.Contains)) result.Append (" 1 special character");
         } else result.Append (" 6 characters");
         if (result.Length is 0) {
            Console.ForegroundColor = ConsoleColor.Green;
            result.Append ("Your password is strong");
         } else result.Insert (0, "Your password is weak.\nIt should have atleast");
         Console.WriteLine (result + "\n");
         Console.ResetColor ();
      }
   }
}
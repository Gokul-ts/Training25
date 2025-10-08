// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to validate a password. The password should have atleast 1 digit, 1 uppercase, 1 lowercase,
// 1 special character and 6 characters. If it satisfies all criteria the password is strong else weak.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25;
internal class Program {
   /// <summary>The password criteria is a combination of all these flags</summary>
   [Flags]
   enum EFlags {
      None = 0,
      Digit = 1,
      Upper = 2,
      Lower = 4,
      Special = 8
   }

   static void Main () {
      for (; ; ) {
         Write ("Enter password: ");
         var input = ReadLine ();
         if (string.IsNullOrWhiteSpace (input) || input.Contains (' ')) {
            WriteLine ("Please enter a valid password!!!");
            continue;
         }
         WriteLine (ValidatePassword (input));
         ResetColor ();
      }
   }

   /// <summary>Checks the validity of password and returns the result.</summary>
   static string ValidatePassword (string input) {
      string spChars = "!@#$%^&*()-+";
      ForegroundColor = ConsoleColor.DarkRed;
      if (input.Length < 6) {
         return "Your password is weak.\nIt should have at least 6 characters";
      }
      EFlags criteria = EFlags.None;
      foreach (char c in input) {
         criteria |= c switch {
            _ when char.IsDigit (c) => EFlags.Digit,
            _ when char.IsUpper (c) => EFlags.Upper,
            _ when char.IsLower (c) => EFlags.Lower,
            _ when spChars.Contains (c) => EFlags.Special,
            _ => EFlags.None
         };
         if (criteria == (EFlags.Digit | EFlags.Upper | EFlags.Lower | EFlags.Special)) {
            ForegroundColor = ConsoleColor.Green;
            return "Your password is strong";
         }
      }
      var result = new StringBuilder ("Your password is weak.\nIt should have at least");
      foreach (EFlags flag in Enum.GetValues (typeof (EFlags))) {
         if (criteria.HasFlag (flag)) continue;
         string message = flag switch {
            EFlags.Digit => " 1 digit",
            EFlags.Upper => " 1 upper case",
            EFlags.Lower => " 1 lower case",
            EFlags.Special => " 1 special character",
            _ => ""
         };
         if (!string.IsNullOrEmpty (message))
            result.Append (message);
      }
      return result.ToString ();
   }
}
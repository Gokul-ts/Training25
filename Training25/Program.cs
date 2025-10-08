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
      HasDigit = 1,
      HasUpper = 2,
      HasLower = 4,
      HasSpecial = 8
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
      var result = new StringBuilder ("Your password is weak.\nIt should have at least");
      if (input.Length < 6) {
         result.Append (" 6 characters");
         return result.ToString ();
      }
      EFlags criteria = EFlags.None;
      foreach (char c in input) {
         criteria |= c switch {
            _ when char.IsDigit (c) => EFlags.HasDigit,
            _ when char.IsUpper (c) => EFlags.HasUpper,
            _ when char.IsLower (c) => EFlags.HasLower,
            _ when spChars.Contains (c) => EFlags.HasSpecial,
            _ => EFlags.None
         };
         if (criteria == (EFlags.HasDigit | EFlags.HasUpper | EFlags.HasLower | EFlags.HasSpecial)) {
            ForegroundColor = ConsoleColor.Green;
            return "Your password is strong";
         }
      }
      foreach (EFlags flag in Enum.GetValues (typeof (EFlags))) {
         if (criteria.HasFlag (flag)) continue;
         string message = flag switch {
            EFlags.HasDigit => " 1 digit",
            EFlags.HasUpper => " 1 upper case",
            EFlags.HasLower => " 1 lower case",
            EFlags.HasSpecial => " 1 special character",
            _ => ""
         };
         if (!string.IsNullOrEmpty (message))
            result.Append (message);
      }
      return result.ToString ();
   }
}
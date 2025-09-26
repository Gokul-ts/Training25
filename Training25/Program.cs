// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print pascal's triangle for given number of rows.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Console.Write ("Enter the number of rows (max 100): ");
         if (int.TryParse (Console.ReadLine (), out int rowCnt) && rowCnt is > 0 and <= 100) {
            var rows = new int[rowCnt];
            for (int i = 0; i < rowCnt; i++) {
               for (int j = i; j > 0; j--) rows[j] = rows[j] + rows[j - 1];
               rows[0] = 1;
               Console.Write (new string (' ', (rowCnt - i) * 2));
               for (int j = 0; j <= i; j++) Console.Write ($"{rows[j],4}");
               Console.WriteLine ();
            }
         } else Console.WriteLine ("Please enter a valid number!!!\n");
      }
   }
}
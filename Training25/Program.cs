// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print pascal's triangle for given number of rows.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      for (; ; ) {
         Write ("Enter the number of rows (max 100): ");
         if (int.TryParse (ReadLine (), out int rowCnt) && rowCnt > 0 && rowCnt <= 100) {
            var rows = new int[rowCnt];
            int max = 1;
            for (int i = 0; i < rowCnt; i++) {
               for (int j = i; j > 0; j--)
                  rows[j] += rows[j - 1];
               rows[0] = 1;
            }
            foreach (var num in rows)
               if (num > max) max = num;
            int width = max.ToString ().Length + 2; // width of max number + 2 spaces
            Array.Clear (rows, 0, rowCnt);
            for (int i = 0; i < rowCnt; i++) {
               for (int j = i; j > 0; j--)
                  rows[j] += rows[j - 1];
               rows[0] = 1;
               Write (new string (' ', ((rowCnt - i - 1) * width) / 2));
               for (int j = 0; j <= i; j++)
                  Write (rows[j].ToString ().PadLeft (width));
               WriteLine ();
            }
         } else WriteLine ("Please enter a valid number!!!\n");
      }
   }
}
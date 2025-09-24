// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print pascal's triangle for given number of rows.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main (string[] args) {
      for (; ; ) {
         Console.Write ("Enter the number of rows (max 100): ");
         if (int.TryParse (Console.ReadLine (), out int rows) && rows is > 0 and <= 100) {
            int[] row = new int[rows];
            for (int i = 0; i < rows; i++) {
               for (int j = i; j > 0; j--) row[j] = row[j] + row[j - 1];
               row[0] = 1;
               Console.Write (new string (' ', (rows - i) * 2));
               for (int j = 0; j <= i; j++) Console.Write ($"{row[j],4}");
               Console.WriteLine ();
            }
         } else Console.WriteLine ("Please enter a valid number!!!\n");
      }
   }
}
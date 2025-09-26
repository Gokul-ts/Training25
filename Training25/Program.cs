// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to Multiplication tables from 1-10.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main () {
      Console.WriteLine ("Multiplication tables (1-10):\n");
      for (int i = 1; i <= 10; i += 2)
         PrintTableTwice (i);
   }

   /// <summary>Prints multiplication table with input num and num+1</summary>
   static void PrintTableTwice (int num) {
      for (int i = 1; i <= 10; i++)
         Console.WriteLine ($"{num} * {i,2} = {num * i} \t {num + 1} * {i,2} = {(num + 1) * i}{(i is 10 ? "\n" : "")}");
   }
}
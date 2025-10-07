// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print chess board with pieces.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      OutputEncoding = new UnicodeEncoding ();
      PrintChessBoard ();
   }

   /// <summary>Prints chess board to the console</summary>
   static void PrintChessBoard () {
      string[] whitePieces = { "\u2656", "\u2658", "\u2657", "\u2655", "\u2654" },
               blackPieces = { "\u265C", "\u265E", "\u265D", "\u265B", "\u265A" };
      string whitePawn = "\u2659", blackPawn = "\u265F";
      WriteLine ("┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓");
      for (int row = 0; row < 8; row++) {
         Write ("┃");
         for (int col = 0; col < 8; col++) {
            string cellContent = row switch {
               0 => $" {(col > 4 ? blackPieces[7 - col] : blackPieces[col])} ┃",
               1 => $" {blackPawn} ┃",
               6 => $" {whitePawn} ┃",
               7 => $" {(col > 4 ? whitePieces[7 - col] : whitePieces[col])} ┃",
               _ => "   ┃"
            };
            Write (cellContent);
         }
         if (row < 7) Write ("\n┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫\n");
      }
      Write ("\n┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛\nLet's play chess!! \u265B");
   }
}
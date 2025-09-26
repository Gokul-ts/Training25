// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print chess board with pieces.
// ------------------------------------------------------------------------------------------------
using System.Text;

namespace Training25;
internal class Program {
   static void Main () {
      Console.OutputEncoding = new UnicodeEncoding ();
      PrintChessBoard ();
   }

   /// <summary>Prints chess board to the console</summary>
   static void PrintChessBoard () {
      string[] whitePieces = { "\u2656", "\u2658", "\u2657", "\u2655", "\u2654" },
               blackPieces = { "\u265C", "\u265E", "\u265D", "\u265B", "\u265A" };
      string whitePawn = "\u2659", blackPawn = "\u265F";
      Console.WriteLine ("┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓");
      for (int row = 0; row < 8; row++) {
         Console.Write ("┃");
         for (int col = 0; col < 8; col++) {
            switch (row) {
               case 0:
                  Console.Write (" " + (col > 4 ? blackPieces[7 - col] : blackPieces[col]) + " ┃");
                  break;
               case 1:
                  Console.Write (" " + blackPawn + " ┃");
                  break;
               case 6:
                  Console.Write (" " + whitePawn + " ┃");
                  break;
               case 7:
                  Console.Write (" " + (col > 4 ? whitePieces[7 - col] : whitePieces[col]) + " ┃");
                  break;
               default:
                  Console.Write ("   ┃");
                  break;
            }
         }
         if (row < 7) Console.Write ("\n┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫\n");
      }
      Console.Write ("\n┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛\nLet's play chess!! \u265B");
   }
}
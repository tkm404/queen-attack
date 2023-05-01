using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack.Models;
using System.Collections.Generic;
using System;

namespace QueenAttack.Tests
{
  [TestClass]
  public class PieceTests
  {
    [TestMethod]
    public void
    PieceConstructor_CreatesInstanceOfPiece_Piece()
    {
      Piece newPiece = new Piece(2, 4, "Tom");
      Assert.AreEqual(typeof(Piece), newPiece.GetType());
    }

    [TestMethod]
    public void PieceCoord_SetsCoordsForPiece_Piece()
    {
      int xPos = 2;
      int yPos = 4;
      Piece newPiece = new Piece (xPos, yPos, "Kyle");
      Assert.AreEqual(xPos, newPiece.XCoord);
      Assert.AreEqual(yPos, newPiece.YCoord);
    }

    [TestMethod]
    public void PieceName_SetsNameForPiece_Piece()
    {
      string pieceName =  "Queen";
      Piece newPiece = new Piece (1, 5, pieceName);
      Assert.AreEqual(pieceName, newPiece.Name);
    }
  }
}
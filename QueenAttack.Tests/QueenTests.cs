using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack.Models;
using System.Collections.Generic;
using System;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenTests
  {
    [TestMethod]
    public void
    QueenConstructor_CreatesInstanceOfQueen_Queen()
    {
      Queen newQueen = new Queen(2, 4);
      Assert.AreEqual(typeof(Queen), newQueen.GetType());
    }

    [TestMethod]
    public void QueenCoord_SetsCoordsForQueen_Queen()
    {
      int xPos = 2;
      int yPos = 4;
      Queen newQueen = new Queen (xPos, yPos);
      Assert.AreEqual(xPos, newQueen.XCoord);
      Assert.AreEqual(yPos, newQueen.YCoord);
    }
  }
}
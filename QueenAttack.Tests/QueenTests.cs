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
      Queen newQueen = new Queen();
      Assert.AreEqual(typeof(Queen), newQueen.GetType());
    }
  }
}
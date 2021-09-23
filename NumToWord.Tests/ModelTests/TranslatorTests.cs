using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scorer.Models;
using System;

namespace Scorer.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void ScoreCalc_CheckAScore_1()
    {
      Assert.AreEqual(1, Game.ScoreCalc("a"));
    }
    [TestMethod]
    public void ScoreCalc_CheckZScore_10()
    {
      Assert.AreEqual(10, Game.ScoreCalc("q"));
    }
    [TestMethod]
    public void ScoreCalc_CheckABCScoreWithCapitals_7()
    {
      Assert.AreEqual(7, Game.ScoreCalc("aBc"));
    }
    [TestMethod]
    public void ScoreCalc_CheckBlankScore_0()
    {
      Assert.AreEqual(0, Game.ScoreCalc(""));
    }
    [TestMethod]
    public void ScoreCalc_CheckSpecialCharactersScore_0()
    {
      Assert.AreEqual(0, Game.ScoreCalc("/.,"));
    }
  }
}

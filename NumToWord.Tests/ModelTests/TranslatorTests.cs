using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumToWord.Models;
using System;

namespace NumToWord.Tests
{
  [TestClass]
  public class TranslatorTests
  {
    [TestMethod]
    public void ScoreCalc_CheckAScore_1()
    {
      Assert.AreEqual("one", Translator.NumToString(1));
    }

  }
}

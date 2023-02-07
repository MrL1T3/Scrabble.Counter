using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Play.ClearAll();
    }

    [TestMethod]
    public void Word_Constructor()
    {
      string testWord = "test";
      Play test = new Play(testWord);
      Assert.AreEqual(typeof(Play), test.GetType());
      Assert.AreEqual("test", test.InputWord);
    }    

    [TestMethod]
    public void Word_SplitWord()
    {
      string testWord = "test";
      Play test = new Play(testWord);
      char[] charArray = {'t','e','s','t'};
      char[] testArray = test.SplitWord();
      Assert.AreEqual(charArray[0], testArray[0]);
      Assert.AreEqual(charArray[1], testArray[1]);
      Assert.AreEqual(charArray[2], testArray[2]);
      Assert.AreEqual(charArray[3], testArray[3]);
    }    

    [TestMethod]
    public void Word_GetScore()
    {
      string testWord = "test";
      string testWord2 = "Fuzzy";
      Play test = new Play(testWord);
      Play test2 = new Play(testWord2);
      int testScore = test.GetScore();
      int testScore2 = test2.GetScore();
      Assert.AreEqual(4, testScore);
      Assert.AreEqual(29, testScore2);
    }  
  }
}

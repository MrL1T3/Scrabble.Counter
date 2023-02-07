using System.Collections.Generic;
using System.Linq; 

namespace Scrabble.Models
{
  public class Play
  {
    public string InputWord { get; set;}
    public static Dictionary <int, char[]> ScoreCard = new Dictionary<int, char[]>()
    {
      {1, new char[]{'A','E','I','O','U','L','N','R','S','T'}},
      {2, new char[]{'D','G'}},
      {3, new char[]{'B','C', 'M', 'P'}},
      {4, new char[]{'F','H', 'V', 'W', 'Y'}},
      {5, new char[]{'K'}},
      {8, new char[]{'J','X'}},
      {10, new char[]{'Q','Z'}}
    };
    
    public Play (string inputW) 
    {
      InputWord = inputW;
    }

    public char[] SplitWord()
    {
      string input = InputWord;
      char[] letters = input.ToCharArray();
      return letters;
    }

    public int GetScore()
    {
      char[] inputArray = SplitWord();
      int scoreCounter = 0;
      foreach (char letter in inputArray)
      {
        foreach (var score in ScoreCard)
        {
          if (score.Value.Contains(char.ToUpper(letter))) 
          {
            scoreCounter += score.Key;
          } 
        }
      }
      return scoreCounter; 
    }

    public static void ClearAll()
    {
      //do nothing 
    }
  }
}
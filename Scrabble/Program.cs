using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please Enter Your Scrabble Word");
      string userInput = Console.ReadLine();
      Play user = new Play(userInput);
      int result = user.GetScore();
      Console.WriteLine("You scored: " + result);
      Main();
    }
  }
}
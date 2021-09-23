using System;
using System.Collections.Generic;

// method that takes in a string
// scoring dictionary {a, 1}, ...
// parse each letter into a list
// for loop
// if list[index] is in the dictionary[index2] --> score += dictionary[index2]
// {"a", "b", "c"} --> 7
// return score
namespace Scorer.Models
{
  public class Game
  {
    public static int ScoreCalc(string word)
    {
      string inputWord = word.ToLower();
      char[] wordLower = inputWord.ToCharArray();
      char[] onePoint = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      char[] twoPoint = {'d', 'g'};
      char[] threePoint = {'b', 'c', 'm', 'p'};
      char[] fourPoint = {'f', 'h', 'v', 'w', 'y'};
      char[] fivePoint = {'k'};
      char[] eightPoint = {'j', 'x'};
      char[] tenPoint = {'q', 'z'};
      int totalScore = 0;

      for (int i = 0; i < inputWord.Length; i++)
        if (Array.Exists(onePoint, element => element == wordLower[i]))
        {
          totalScore += 1;
        }
        else if (Array.Exists(twoPoint, element => element == wordLower[i]))
        {
          totalScore += 2;
        }
        else if (Array.Exists(threePoint, element => element == wordLower[i]))
        {
          totalScore += 3;
        }
        else if (Array.Exists(fourPoint, element => element == wordLower[i]))
        {
          totalScore += 4;
        }
        else if (Array.Exists(fivePoint, element => element == wordLower[i]))
        {
          totalScore += 5;
        }
        else if (Array.Exists(eightPoint, element => element == wordLower[i]))
        {
          totalScore += 8;
        }
        else if (Array.Exists(tenPoint, element => element == wordLower[i]))
        {
          totalScore += 10;
        }
        else 
        {
          totalScore += 0;
        }
    return totalScore;
    }
  }
}
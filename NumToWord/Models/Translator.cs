using System;
using System.Collections.Generic;

// dict1 --> numbers to words 1 - one ...
// dict2 --> separater 1 --> ones, 2 --> tens ...
// dict3 --> separater 1 --> ten, 2 --> twenty ...
// as we iterate, check length ==> 3, dict[3] ==> hundreds

// for (int j = inputnumtostring.Length (3); j >= 0; j--) 
//     ^-->prepending dict1's word
//     if j == 2 
// "456"

namespace NumToWord.Models
{
  public class Translator
  {
    public static string NumToString(int number)
    {
      string translated = "";
      Dictionary<int, string> oneToNine = new Dictionary<int, string>() {
        {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"},
        {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"} 
      };
      Dictionary<int, string> teens = new Dictionary<int, string>() {
        {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"},
        {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"} 
      };
      Dictionary<int, string> tens = new Dictionary<int, string>() {
        {10, "ten"}, {20, "twenty"}, {30, "thirty"}, {40, "forty"}, {50, "fifty"},
        {60, "sixty"}, {70, "seventy"}, {80, "eighty"}, {90, "ninety"} 
      };
      string stringNum = number.ToString();
      // Console.WriteLine(stringNum.Length);
      // Console.WriteLine(oneToNine[number]);
      // Console.WriteLine(oneToNine.ContainsKey(number));
      for (int i = 1; i <= stringNum.Length; i++)
      {
        if (stringNum.Length == 1 && oneToNine.ContainsKey(number))
        {
          translated += oneToNine[number];
        }
        else if (stringNum.Length == 2 && teens.ContainsKey(number))
        {
          translated += teens[number];
          Console.WriteLine(translated);
        }
        else if (stringNum.Length == 2 && tens.ContainsKey(number))
        {
          translated += tens[number];
          Console.WriteLine(translated);
        }
      }

      return translated;
    }
  }
}

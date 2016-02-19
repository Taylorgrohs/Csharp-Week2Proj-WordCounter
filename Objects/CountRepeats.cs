using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RepeatCounter
{
  public class Sentence
  {
    public string Count(string wordToCount, string sentenceToCheck)
    {
      string word = wordToCount.ToLower();
      string[] sentence = sentenceToCheck.ToLower().Split(' ');
      int repeatNum = 0;
      foreach (string i in sentence)
      {
        if (word == Regex.Replace(i, @"[^\w\s]", ""));
        {
        repeatNum = repeatNum + 1;
        }
      }
      return wordToCount + " was repeated in " + sentenceToCheck + " " + repeatNum + " time(s).";
    }
  }
}

using System;
using System.Collections.Generic;

namespace AnagramMaker.Models
{
  public class Gram
  {
    private string _word;
    private List<string> _wordList = new List<string> {};

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    public Gram(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string userWord)
    {
      _word = userWord;
    }

    public List<string> GetWordList()
    {
      return _wordList;
    }

    public void AddWord(string word)
    {
      _wordList.Add(word);
    }

    public string SortWord()
    {
      char[] toSort = _word.ToCharArray();
      Array.Sort(toSort);
      return string.Join("",toSort);
    }
  }
}

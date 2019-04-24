using System;
using System.Collections.Generic;
using AnagramMaker.Models;

namespace Anagram
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to compare to a list of words to anagramafy");
      Gram newGram = new Gram(Console.ReadLine());
      bool listMaking = true;
      List<string> listArray = new List<string> { };
      List<string> matches = new List<string> { };
      while (listMaking)
      {
        Console.WriteLine("What word would you like to compare to your primary word");
        string userEnters = Console.ReadLine();
        listArray.Add(userEnters);

        Console.WriteLine("Do you want to enter another word? '1' for yes");

        if (Console.ReadLine() != "1")
        {
          listMaking = false;
        }
      }
      for (int i = 0; i < listArray.Count; i++)
      {
        char[] toSort = listArray[i].ToCharArray();
        Array.Sort(toSort);
        string sorted = string.Join("",toSort);

        if(sorted == newGram.SortWord())
        {
          matches.Add(listArray[i]);
        }
      }
      Console.WriteLine("Here are the anagrams of your word:");
      Console.WriteLine("-----------------------------------");
      foreach (String gramcracker in matches)
      {
        Console.WriteLine(gramcracker);
      }
      Console.WriteLine("LIIIIL BIIIIISSCUIT");
    }
  }
}

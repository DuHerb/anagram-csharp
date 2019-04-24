using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramMaker.Models;

namespace Anagram.TestTools
{
  [TestClass]
  public class GramTest
  {
    // public void Dispose()
    // {
    //   Gram.ClearAll();
    // }

    [TestMethod]
    public void GramConstructor_CreateInstanceOfGram_Gram()
    {
      Gram newGram = new Gram("cracker");
      Assert.AreEqual(typeof(Gram), newGram.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      //arrange
      string word = "cracker";
      Gram newGram = new Gram(word);
      //act
      string result = newGram.GetWord();
      //assert
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void SetWord_SetWord_String()
    {
      //Arrange
    string word = "cracker";
    Gram newGram = new Gram(word);

    //Act
    string updatedWord = "biscuit";
    newGram.SetWord(updatedWord);
    string result = newGram.GetWord();

    //Assert
    Assert.AreEqual(updatedWord, result);
    }

    [TestMethod]
    public void GetWordList_ReturnsGrams_GramList()
    {
      Gram newGram = new Gram("wordOne");
      List<string> newList = new List<string> { };
      //Act
      List<string> result = newGram.GetWordList();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddWord_AddWordtoWordList_ItemList()
    {
      //Arrange
      string word = "dough";
      Gram newGram = new Gram("hug");
      List<string> newList = new List<string> { word };

      //Act
      newGram.AddWord(word);
      List<string> result = newGram.GetWordList();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void SortWord_SortWordIntoCharArray_CharArray()
    {
      string word = "cat";
      Gram newGram = new Gram(word);
      string sortedWord = "act";
      string result = newGram.SortWord();

      Assert.AreEqual(sortedWord, result);
    }

  }
}

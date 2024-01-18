using RPS.Models;
using System.Collections.Generic;
using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests;

[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void ConstructorCheck_CheckIfGameInstanceExists_RPSGame()
  {
    RPSGame newGame = new RPSGame();
    Assert.AreEqual(typeof(RPSGame), newGame.GetType());
  }

  [TestMethod]
  public void GetPlayerOneChoice_ReturnUserOneInput_String()
  {
    RPSGame newGame = new RPSGame();
    newGame.PlayerOneChoice = "rock";
    Assert.AreEqual(newGame.PlayerOneChoice, "rock");
  }

  [TestMethod]
  public void GetPlayerTwoChoice_ReturnUserTwoInput_String()
  {
    RPSGame newGame = new RPSGame();
    newGame.PlayerTwoChoice = "rock";
    Assert.AreEqual(newGame.PlayerTwoChoice, "rock");
  }

  [TestMethod]
  public void SetPlayerOneChoice_SetValueOfPlayerOne_Void()
  {
    RPSGame newGame = new RPSGame();
    string newValue = "hello";
    newGame.PlayerOneChoice = newValue;
    Assert.AreEqual(newValue, newGame.PlayerOneChoice);
  }

  [TestMethod]
  public void SetPlayerTwoChoice_SetValueOfPlayerTwo_Void()
  {
    RPSGame newGame = new RPSGame();
    string newValue = "goodbye";
    newGame.PlayerTwoChoice = newValue;
    Assert.AreEqual(newValue, newGame.PlayerTwoChoice);
  }
}



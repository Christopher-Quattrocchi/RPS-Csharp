using RPS.Models;
using System.Collections.Generic;
using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.UserInterfaceModels;

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

  [TestMethod]
  public void CheckWinner_CheckIfDraw_String()
  {
    RPSGame newGame = new RPSGame();
    newGame.PlayerOneChoice = "rock";
    newGame.PlayerTwoChoice = "rock";
    Assert.AreEqual(newGame.CheckWinner(), "Draw");
  }
  [TestMethod]
  public void CheckWinner_CheckIfPlayerOneWins_String()
  {
    RPSGame newGame = new RPSGame();
    newGame.PlayerOneChoice = "rock";
    newGame.PlayerTwoChoice = "scissors";
    Assert.AreEqual(newGame.CheckWinner(), PlayerOneWinsBanner.PlayerOneWins);
  }
  [TestMethod]
  public void CheckWinner_CheckIfPlayerTwoWins_String()
  {
    RPSGame newGame = new RPSGame();
    newGame.PlayerOneChoice = "rock";
    newGame.PlayerTwoChoice = "paper";
    Assert.AreEqual(newGame.CheckWinner(), PlayerTwoWinsBanner.PlayerTwoWins);
  }
  [TestMethod]
  public void CheckCompRandom_CheckIfCompAssignedChoice_String()
  {
    RPSGame newGame = new RPSGame();
    newGame.ComputerPick();
    List<string> validChoices = new List<string> {"rock", "paper", "scissors"};
    bool isValidChoice = validChoices.Contains(newGame.ComputerChoice);
    Assert.IsTrue(isValidChoice, $"Invalid choice: {newGame.ComputerChoice}");
    
  }
}



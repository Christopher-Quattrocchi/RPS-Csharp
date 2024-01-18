using System.Collections.Generic;
using System.Globalization;
using RPS.UserInterfaceModels;

namespace RPS.Models
{
  public class RPSGame
  {
    private string _playerOneChoice;
    public string PlayerOneChoice
    {
      get { return _playerOneChoice; } 
      set { _playerOneChoice = value; }
    }

    private string _playerTwoChoice;
    public string PlayerTwoChoice
    {
      get { return _playerTwoChoice; }
      set { _playerTwoChoice = value; }
    }

    private string _computerChoice;
    public string ComputerChoice
    {
      get { return _computerChoice; }
      set { _computerChoice = value; }
    }

    public void PlayTwoPlayerGame(string playerOneChoice, string playerTwoChoice)
    {
      PlayerOneChoice = playerOneChoice;
      PlayerTwoChoice = playerTwoChoice;
    }

    public void PlayComputerGame(string playerOneChoice)
    {
      PlayerOneChoice = playerOneChoice;
      ComputerChoice = ComputerPick();
      PlayerTwoChoice = ComputerChoice;
    }

    public string ComputerPick()
    {
      Random random = new Random();
      int choice = random.Next(1, 4);

      if (choice == 1)
      {
        ComputerChoice = "rock";
        return "rock";
      } 
      else if (choice == 2) 
      {
        ComputerChoice = "paper";
        return "paper";
      } 
      else
      {
        ComputerChoice = "scissors";
        return "scissors";
      } 
    }
    public string CheckWinner()
    {
      if (_playerOneChoice == _playerTwoChoice)
      {
        return Draw.GameDraw;
      }
      else if ((_playerOneChoice == "rock" && _playerTwoChoice == "scissors") || 
      (_playerOneChoice == "scissors" && _playerTwoChoice == "paper") || 
      (_playerOneChoice == "paper" && _playerTwoChoice == "rock"))
      {
        return PlayerOneWinsBanner.PlayerOneWins;
      }
      else
      {
        return PlayerTwoWinsBanner.PlayerTwoWins;
      }
    }

    public string CheckWinnerComp()
    {
      if (_playerOneChoice == _computerChoice)
      {
        return Draw.GameDraw;
      }
      else if ((_playerOneChoice == "rock" && _computerChoice == "scissors") || 
      (_playerOneChoice == "scissors" && _computerChoice == "paper") || 
      (_playerOneChoice == "paper" && _computerChoice == "rock"))
      {
        return PlayerOneWinsBanner.PlayerOneWins;
      }
      else
      {
        return ComputerWinsBanner.ComputerWins;
      }
    }
  }
}
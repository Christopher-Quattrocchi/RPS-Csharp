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

    public string CheckWinner()
    {
      if (_playerOneChoice == _playerTwoChoice)
      {
        return "Draw";
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
  }
}
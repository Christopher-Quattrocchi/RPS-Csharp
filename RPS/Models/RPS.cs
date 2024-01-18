using System.Collections.Generic;
using System.Globalization;

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

  }
}
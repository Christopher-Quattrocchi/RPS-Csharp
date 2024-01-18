using System;
using RPS.Models;
using System.Collections.Generic;
using RPS.UserInterfaceModels;
using System.Runtime.CompilerServices;

namespace RPS
{
  class RPSDisplay
  {
    static void Main()
    {
      Console.WriteLine(WelcomeBanner.Welcome);
      while (true)
      {
        RPSGame newGame = new RPSGame();

        Console.WriteLine("Let's Play Rock, Paper, Scissors!");

        Console.WriteLine("Player One, type 'R' for ROCK, 'P' for PAPER, or 'S' for Scissors");
        Console.WriteLine("Type 'exit' at any time to close this game");
        string playerOneResponse = Console.ReadLine();
        if (playerOneResponse == "exit") break;
        string P1Choice = ValidateChoice(playerOneResponse);
        
        newGame.PlayerOneChoice = P1Choice;

        Console.WriteLine("Player Two, type 'R' for ROCK, 'P' for PAPER, or 'S' for Scissors");
        string playerTwoResponse = Console.ReadLine();
        if (playerTwoResponse == "exit") break;
        string P2Choice = ValidateChoice(playerTwoResponse);
        newGame.PlayerTwoChoice = P2Choice;

        if (P1Choice != null && P2Choice != null)
        {
          string checker = newGame.CheckWinner();
          Console.WriteLine(checker);
        }
        Console.WriteLine("Do you want to play again? Enter 'y' or 'n'...");
        string again = Console.ReadLine();
        if (again == "y" || again == "Y")
        {
          Main();
        }
        else
        {
          Console.WriteLine(Goodbye.GameClose);
          break;
        }
      }


    }
    private static string ValidateChoice(string choice)
    {
      switch (choice.ToUpper())
      {
        case "R":
          return "rock";
        case "P":
          return "paper";
        case "S":
          return "scissors";
        default:
          Console.WriteLine("Please make a valid selection");
          return "";
      }
    }
  }
}


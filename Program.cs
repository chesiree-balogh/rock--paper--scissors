using System;

namespace rock__paper__scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      //welcome the user
      Console.WriteLine("Hello there! My name's Bot.");
      Console.WriteLine("Ready for an epic battle of...");
      Console.WriteLine("ROCK, PAPER, SCISSOR???");

      //list of options... rock, paper, scissors
      Console.WriteLine("Choose a weapon: Rock, Paper, or Scissor.");
      var playersChoice = Console.ReadLine().ToLower();

      //make sure user only choses one of the given choices




      //computer picks random option
      Random rnd = new Random();
      string[] computersChoice = { "rock", "paper", "scissor" };
      int compChoice = rnd.Next(computersChoice.Length);
      var botsPick = computersChoice[compChoice];


      //list game outcome options and appropriate response to user:

      //user picks rock & comp picks rock = tie
      if (playersChoice == "rock" || playersChoice == "paper" || playersChoice == "scissor")
      {
        if (playersChoice == "rock" && botsPick == "rock")
        {
          Console.WriteLine("Bot- Ahhh I picked: " + computersChoice[compChoice] + ", looks like it's a tie!");
        }

        //user picks rock & comp picks paper = comp wins
        if (playersChoice == "rock" && botsPick == "paper")
        {
          Console.WriteLine("Bot- Mooohahaha I picked: " + computersChoice[compChoice] + ", I win!");
        }

        //user picks rock & comp picks scissor = user wins
        if (playersChoice == "rock" && botsPick == "scissor")
        {
          Console.WriteLine("Bot- Booo I picked: " + computersChoice[compChoice] + ", looks like you beat me!");
        }

        //user picks paper & comp picks rock = user wins
        if (playersChoice == "paper" && botsPick == "rock")
        {
          Console.WriteLine("Bot- Booo I picked: " + computersChoice[compChoice] + ", looks like you beat me!");
        }

        //user picks paper & comp picks paper = tie
        if (playersChoice == "paper" && botsPick == "paper")
        {
          Console.WriteLine("Bot- Ahhh I picked: " + computersChoice[compChoice] + ", looks like it's a tie!");
        }

        //user picks paper & comp picks scissor = comp wins
        if (playersChoice == "paper" && botsPick == "scissor")
        {
          Console.WriteLine("Bot- Mooohahaha I picked: " + computersChoice[compChoice] + ", I win!");
        }

        //user picks scissors & comp picks rock = comp wins
        if (playersChoice == "scissor" && botsPick == "rock")
        {
          Console.WriteLine("Bot- Mooohahaha I picked: " + computersChoice[compChoice] + ", I win!");
        }

        //user picks scissors & comp picks paper = user wins
        if (playersChoice == "scissor" && botsPick == "paper")
        {
          Console.WriteLine("Bot- Booo I picked: " + computersChoice[compChoice] + ", looks like you eat me!");
        }

        //user picks scissors & comp picks scissor = tie
        if (playersChoice == "scissor" && botsPick == "scissor")
        {
          Console.WriteLine("Bot- Ahhh I picked: " + computersChoice[compChoice] + ", looks like it's a tie!");
        }
      }
      else
      {
        Console.WriteLine("Your didn't pick a valid weapon!");
      }



    }
  }
}

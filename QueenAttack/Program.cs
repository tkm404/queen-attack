using System;
// using System.Collections.Generic;
using QueenAttack.Models;
using QueenAttack.UserInterfaceModels;

namespace QueenAttack
{
  class Program
  {
    static void Main(string[] args)
    {
      RunDMC();
    }

    private static void RunDMC()
    {
      Console.WriteLine($"{Banner.Welcome}");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Queen Attack!!");
      Console.WriteLine("Enter in a x-coord for the King piece (1-8)");
      int kingXPos = SafeGet();

      Console.WriteLine("Enter in a y-coord for the King piece (1-8)");
      int kingYPos = SafeGet();

      Console.WriteLine("Enter in a x-coord for the Queen piece (1-8)");
      int queenXPos = SafeGet();

      Console.WriteLine("Enter in a y-coord for the Queen piece (1-8)");
      int queenYPos = SafeGet();

      Console.WriteLine("Let's BATTLE!");

      Piece king = new Piece(kingXPos, kingYPos, "King");
      king.GetRemainderSum();

      Piece queen = new Piece(queenXPos, queenYPos, "Queen");
      queen.GetRemainderSum();

      Console.WriteLine("They are...");
      if (queen.Remainder == king.Remainder)
      {
        Console.WriteLine("CHECK'D SON!");
      }
      else
      {
        Console.WriteLine("Safe... for now...");
      }
      Console.WriteLine("Play again? (Y/N)");
      Console.WriteLine("Enter 'Y' to start again, or enter 'N' to quit... like a coward.");
      string userResponse = Console.ReadLine();
      if (userResponse == "Y" || userResponse == "y")
      {
        // play again
        RunDMC();
      }
      else
      {
        Console.WriteLine("See you next time... WATCH YOUR BACK!");
      }
    }

    private static int SafeGet()
    {
      string input = Console.ReadLine();

      if (int.TryParse(input, out int inputNum))
      {
        return inputNum;
      }
      else
      {
        Console.WriteLine("Please enter a valid number");
        SafeGet();
        return 0;
      }
    }
  }
}
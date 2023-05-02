using System;
using System.Collections.Generic;
using QueenAttack.Models;
using QueenAttack.UserInterfaceModels;

namespace QueenAttack
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine($"{Banner.Welcome}");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Queen Attack!!");
      Console.WriteLine("Enter in a x-coord for the King piece (1-8)");
      string stringKingX = Console.ReadLine();
      Console.WriteLine("Enter in a y-coord for the King piece (1-8)");
      string stringKingY = Console.ReadLine();
      Console.WriteLine("Enter in a x-coord for the Queen piece (1-8)");
      string stringQueenX = Console.ReadLine();
      Console.WriteLine("Enter in a y-coord for the Queen piece (1-8)");
      string stringQueenY = Console.ReadLine();
      Console.WriteLine("Let's BATTLE!");
      int kingXPos = int.Parse(stringKingX);
      int kingYPos = int.Parse(stringKingY);
      Piece king = new Piece(kingXPos, kingYPos, "King");
      king.GetRemainderSum();
      int queenXPos = int.Parse(stringQueenX);
      int queenYPos = int.Parse(stringQueenY);
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
        Main();
      }
      else
      {
        Console.WriteLine("See you next time... WATCH YOUR BACK!");
      }
    }

    


  }
}
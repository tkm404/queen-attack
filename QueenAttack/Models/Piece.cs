using System.Collections.Generic;

namespace QueenAttack.Models
{
  public class Piece
  {
    public int XCoord { get; set; }
    public int YCoord { get; set; }
    public string Name { get; set; }
    public int Remainder { get; set; }

    public List<int> ComparatorList = new List<int> {};

    public Piece(int xPos, int yPos, string pieceName)
    {
      XCoord = xPos;
      YCoord = yPos;
      Name = pieceName;
    }

    public int GetRemainderSum()
    {
      int remainderSum = (this.XCoord % 2) + (this.YCoord % 2);
      this.Remainder = remainderSum % 2;
      return this.Remainder;
    } 
  }
}
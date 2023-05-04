using System.Collections.Generic;

namespace QueenAttack.Models
{
  public class Piece
  {
    public int XCoord { get; set; }
    public int YCoord { get; set; }
    public string Name { get; set; }
    public int Remainder { get; set; }

    public Piece(int xPos, int yPos, string pieceName)
    {
      XCoord = xPos;
      YCoord = yPos;
      Name = pieceName;
    }

    public void GetRemainderSum()
    {
      int remainderSum = (this.XCoord % 2) + (this.YCoord % 2);
      this.Remainder = remainderSum % 2;
      // return this.Remainder;
    } 
  }
}
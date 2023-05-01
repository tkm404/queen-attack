using System.Collections.Generic;

namespace QueenAttack.Models
{
  public class Piece
  {
    public int XCoord { get; set; }
    public int YCoord { get; set; }
    public string Name { get; set; }

    public List<int> ComparatorList = new List<int> {};

    public Piece(int xPos, int yPos, string pieceName)
    {
      XCoord = xPos;
      YCoord = yPos;
      Name = pieceName;
    }

    public List<int> GetRemainderList()
    {
      List<int> remainderList = new List<int> {};
      remainderList.Add(this.XCoord % 2);
      remainderList.Add(this.YCoord % 2);
      this.ComparatorList = remainderList;
      return remainderList;
    } 

    public List<int> GetPositionList()
    {
      List<int> positionList = new List<int> {};
      positionList.Add(this.XCoord);
      positionList.Add(this.YCoord);

      return positionList;
    } 
  }
}
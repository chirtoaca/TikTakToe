using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
  public interface IGame
    {
        
        void Start(byte playerNo);
        
        byte GetNextPlayerNo();
        
        void Move(int x, int y);
        
        bool Finished { get; }
    }
}

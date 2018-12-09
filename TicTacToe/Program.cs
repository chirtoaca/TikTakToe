using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(5); //A new game with winning row of 5 symbols is created

            game.Start(1);        //First player moves at (0,0)
            game.Move(-2,-3);     //Second player moves at (-2, -3)
            
            game.Move(2, 3);      //First player moves at (2,3)
            game.Move(1, 3);      //Second player moves at (1,3)
            
            game.Move(3,4);      //First player moves at (3,4)
            game.Move(1, 5);      //Second player moves at (1,5)
           
            game.Move(4,5);      //First player moves at (4,5)
            game.Move(2, 7);      //Second player moves at (2,7)
            
            game.Move(5,6);      //First player moves at (5,6)
            game.Move(3,8);      //Second player moves at (3,8)
            
            game.Move(6,7);      //First player moves at (6,7)
                                 //game.Finished is True. The first player managed a diagonal row.

        }
    }
}

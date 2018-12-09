using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game : IGame
    {
 
        private readonly byte[,] _board = new byte[byte.MaxValue, byte.MaxValue];
        private byte _playerNo;
        private int _cellForWin;

        public Game(int cellsForWin)
        {
            _cellForWin = cellsForWin;
        }



        public void Start(byte playerNo)
        {
            if (playerNo == 1 || playerNo == 2)
            {
                _playerNo = playerNo;
                _board[byte.MaxValue / 2, byte.MaxValue / 2] = playerNo;
            }
            else
                Console.WriteLine("Unidentified player number");

        }

        public byte GetNextPlayerNo()
        {
            if (_playerNo == 1)
            {
                _playerNo = 2;
            }
            else if (_playerNo == 2)
            {
                _playerNo = 1;
            }
            return _playerNo;
        }

        public void Move(int x, int y)
        {
            if (_board[byte.MaxValue / 2, byte.MaxValue / 2] != 0)
            {
                if (_board[byte.MaxValue / 2 + x, byte.MaxValue / 2 + y] == 0)
                {
                    _playerNo = GetNextPlayerNo();
                    _board[byte.MaxValue / 2 + x, byte.MaxValue / 2 + y] = _playerNo;
                }
                else
                {
                    Console.WriteLine("This cell is busy");
                }
                Finish();
            }
            else
                Console.WriteLine("Please first run Start method, then Move");


        }
        

        public bool Finished => Finish() ;

        private bool Finish()
        {
            bool result = false;
            

            //Horizontal verification
            for (int i = 0; i < byte.MaxValue; i++)
            {
                int countplayer1 = 0;
                int countplayer2 = 0;

                for (int j = 0; j < byte.MaxValue; j++)
                {
                    if (_board[i, j] == 1)
                    {
                        countplayer1++;
                        countplayer2 = 0;
                    }
                    else if (_board[i, j] == 2)
                    {
                        countplayer2++;
                        countplayer1 = 0;
                    }

                    if (countplayer1 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 1 Win");
                        break;
                    }
                    else if (countplayer2 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 2 Win");
                        break;
                    }
                }
            }
            //Vertical verification
            for (int j = 0; j < byte.MaxValue; j++)
            {
                int countplayer1 = 0;
                int countplayer2 = 0;
                for (int i = 0; i < byte.MaxValue; i++)
                {
                    if (_board[i, j] == 1)
                    {
                        countplayer1++;
                        countplayer2 = 0;
                    }
                    else if (_board[i, j] == 2)
                    {
                        countplayer2++;
                        countplayer1 = 0;
                    }

                    if (countplayer1 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 1 Win");
                        break;
                    }
                    else if (countplayer2 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 2 Win");
                        break;
                    }
                }
            }

            //Diagonal Verification 135*
            for (int j = 0; j < byte.MaxValue; j++)
            {
                int countplayer1 = 0;
                int countplayer2 = 0;
                int i = 0;
                int n = i;
                int m = j;
                while (n != byte.MaxValue - 1 && m != byte.MaxValue - 1)
                {
                    if (_board[n, m] == 1)
                    {
                        countplayer1++;
                        countplayer2 = 0;
                    }
                    else if (_board[n, m] == 2)
                    {
                        countplayer2++;
                        countplayer1 = 0;
                    }


                    if (countplayer1 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 1 Win");
                        break;
                    }
                    else if (countplayer2 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 2 Win");
                        break;
                    }

                    n++;
                    m++;
                }
            }


            for (int i = 1; i < byte.MaxValue; i++)
            {
                int countplayer1 = 0;
                int countplayer2 = 0;
                int j = 0;
                int n = i;
                int m = j;
                while (n != byte.MaxValue && m != byte.MaxValue)
                {
                    if (_board[n, m] == 1)
                    {
                        countplayer1++;
                        countplayer2 = 0;
                    }
                    else if (_board[n, m] == 2)
                    {
                        countplayer2++;
                        countplayer1 = 0;
                    }


                    if (countplayer1 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 1 Win");
                        break;
                    }
                    else if (countplayer2 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 2 Win");
                        break;
                    }

                    n++;
                    m++;
                }
            }


            //Diagonal verification 45*

            for (int i = 0; i < byte.MaxValue; i++)
            {
                int countplayer1 = 0;
                int countplayer2 = 0;
                int j = byte.MaxValue-1;
                int n = i;
                int m = j;

                while (m != i && n<byte.MaxValue)
                {
                    if (_board[n, m] == 1)
                    {
                        countplayer1++;
                        countplayer2 = 0;
                    }
                    else if (_board[n, m] == 2)
                    {
                        countplayer2++;
                        countplayer1 = 0;
                    }


                    if (countplayer1 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 1 Win");
                        break;
                    }
                    else if (countplayer2 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 2 Win");
                        break;
                    }

                    n++;
                    m--;
                }
            }

            for (int j = 0; j < byte.MaxValue; j++)
            {
                int countplayer1 = 0;
                int countplayer2 = 0;
                int i = 0;
                int n = i;
                int m = j;

                while (m != i && m<byte.MaxValue)
                {
                    if (_board[n, m] == 1)
                    {
                        countplayer1++;
                        countplayer2 = 0;
                    }
                    else if (_board[n, m] == 2)
                    {
                        countplayer2++;
                        countplayer1 = 0;
                    }


                    if (countplayer1 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 1 Win");
                        break;
                    }
                    else if (countplayer2 == _cellForWin)
                    {
                        result = true;
                        Console.WriteLine("Player 2 Win");
                        break;
                    }

                    n++;
                    m--;
                }

            }
            return result;
        }


    }
}

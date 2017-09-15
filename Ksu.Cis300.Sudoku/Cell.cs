using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Sudoku
{
    public class Cell
    {
        private int _row;
        private int _column;
        private int _curColor;
        private bool[] _avColors;

        public Cell(int r, int c, int s)
        {
            _row = r;
            _column = c;
            _curColor = s;
            _avColors = new bool[10];
            for(int i =0; i<10; i++)
            {
                _avColors[i] = true;
            }
        }

        public int Value
        {
            get
            {
                return _curColor;
            }
            set
            {
                _curColor = value;
            }
        }

        public int Row
        {
            get
            {
                return _row;
            }
        }

        public int Col
        {
            get
            {
                return _column;
            }
        }

        public bool[] Moves
        {
            get
            {
                return _avColors;
            }
            set
            {
                _avColors = value;
            }
        }

        public void AddMove(int index)
        {
         
            _avColors[index] = true;
        }

        public void RemoveMove(int index)
        {
            while (index != -1)
            {
                _avColors[index] = false;
                return;
            }
        }
    }
}

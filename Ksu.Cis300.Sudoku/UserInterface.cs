/* UserInterface.cs
 * Author: Julie Thornton
 *      Modified by: Ryan Huse
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.Graphs;
using System.IO;
using System.Windows.Forms;

namespace Ksu.Cis300.Sudoku
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The size of the Sudoku puzzle
        /// </summary>
        private int _gridSize = 9;

        /// <summary>
        /// The size of a cell on the Sudoku grid
        /// </summary>
        private const int _cellSize = 40;

        /// <summary>
        /// Graph to hold the cell variables
        /// </summary>
        private DirectedGraph<Cell,int> _graph = null;

        /// <summary>
        /// Look up a cell with its row and column
        /// </summary>
        private Cell[,] _lookup = new Cell[9,9];
        

        /// <summary>
        /// Constructs the GUI
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();

            for (int i = 0; i < _gridSize; i++)
            {
                DataGridViewTextBoxColumn txCol = new DataGridViewTextBoxColumn();
                txCol.MaxInputLength = 1;   
                uxGrid.Columns.Add(txCol);
                uxGrid.Columns[i].Name = "Col " + (i + 1).ToString();
                uxGrid.Columns[i].Width = _cellSize;
                uxGrid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                DataGridViewRow row = new DataGridViewRow();
                row.Height = _cellSize;
                uxGrid.Rows.Add(row);
            }
            //marks the 3x3 grids
            uxGrid.Columns[2].DividerWidth = 2;
            uxGrid.Columns[5].DividerWidth = 2;
            uxGrid.Rows[2].DividerHeight = 2;
            uxGrid.Rows[5].DividerHeight = 2;

            //Demonstrates how to set cell values in the grid
            /// SetCell(0, 0, 4);
            ///SetCell(3, 3, 7);
            ///SetCell(8, 8, 9);

            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    _lookup[i, j] = new Cell(i,j,-1);
                    
                }
            }


        }



        /// <summary>
        /// Sets the value of a grid cell
        /// </summary>
        /// <param name="row">A row in the grid</param>
        /// <param name="col">A column in the grid</param>
        /// <param name="value">The value to place at that position</param>
        public void SetCell(int row, int col, int value)
        {
            uxGrid.Rows[row].Cells[col].Value = value;
        }
        private int EmptyCell()
        {
            int info = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (_lookup[i, j].Value == -1)
                    {
                        info++;
                    }
                }
            }
            return info;
        }


        /// <summary>
        /// Code to actually solve the puzzle
        /// </summary>
        /// <param name="uncolored"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        private bool SolveSudoku(int uncolored, Cell node)
        {
            
                if (uncolored == 0)
                {
                    return true;
                }
                if (node == null)
                {
                    node = _lookup[0, 0];
                }
                while (node.Value != -1)
                {
                    if (node.Col < 8)
                    {
                        node = _lookup[node.Row, node.Col + 1];
                    }
                    else if (node.Row < 8)
                    {
                        node = _lookup[node.Row + 1, 0];
                    }
                    else if (node.Col == 8 && node.Row == 8)
                    {
                        node = _lookup[8, 8];
                    }
                }
                for (int i = 1; i <= 9; i++)
                {
                if (node.Moves[i] == true)
                {
                    node.Value = i;
                    List<Cell> affected = new List<Cell>();
                    foreach (Tuple<Cell, int> adj in _graph.OutgoingEdges(node))
                    {
                        if (adj.Item1.Moves[i] == true)
                        {
                            adj.Item1.RemoveMove(i);
                            affected.Add(adj.Item1);
                        }
                    }
                    if (SolveSudoku(uncolored - 1, node))
                    {
                        return true;
                    }
                    foreach (Cell go in affected)
                    {
                        go.AddMove(i);
                    }
                    node.Value = -1;
                }
                }
                return false;
            
        }


        /// <summary>
        /// When puzzle is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadAPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxOpenFileDialog1.FileName;
                Cell[,] temp = new Cell[9, 9];
                using (StreamReader input = new StreamReader(fileName))
                {
                    int info = 0;
                    while (!input.EndOfStream)
                    {
                        string[] value = input.ReadLine().Split();
                        for (int i = 0; i < value.Length; i++)
                        {
                            Cell cell;
                            if (!value[i].Equals("_"))
                            {
                                cell = new Cell(info, i, Convert.ToInt32(value[i]));
                            }
                            else
                            {
                                cell = new Cell(info, i, -1);
                            }
                            temp[info, i] = cell;
                        }

                        info++;
                    }
                }
                _lookup = temp;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        uxGrid.Rows[i].Cells[j].Value = "";
                        if (_lookup[i, j].Value != -1)
                        {
                            SetCell(i, j, _lookup[i, j].Value);
                        }
                    }
                }
            }

    }

       
        /// <summary>
        /// Code for when solve is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSolve_Click(object sender, EventArgs e)
        {
            
            _graph = new DirectedGraph<Cell, int>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        if (!_lookup[i, j].Equals(_lookup[i, k]) && !_graph.ContainsEdge(_lookup[i, j], _lookup[i, k]))
                        {
                            _graph.AddEdge(_lookup[i, j], _lookup[i, k], 0);
                            if (_lookup[i, k].Value != -1)
                            {
                                _lookup[i, j].RemoveMove(_lookup[i, k].Value);
                            }
                        }

                        if (!_lookup[i, j].Equals(_lookup[k, j]) && !_graph.ContainsEdge(_lookup[i, j], _lookup[k, j]))
                        {
                            _graph.AddEdge(_lookup[i, j], _lookup[k, j], 0);
                            if (_lookup[k, j].Value != -1)
                            {
                                _lookup[i, j].RemoveMove(_lookup[k, j].Value);
                            }
                        }

                        for (int l = 0; l < 9; l++)
                        {
                            if ((i / 3) == (k / 3) && (j / 3) == (l / 3))
                            {
                                if (!_lookup[i, j].Equals(_lookup[k, l]) && !_graph.ContainsEdge(_lookup[i, j], _lookup[k, l]))
                                {
                                    _graph.AddEdge(_lookup[i, j], _lookup[k, l], 0);
                                    if (_lookup[k, l].Value != -1)
                                    {
                                        _lookup[i, j].RemoveMove(_lookup[k, l].Value);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (!SolveSudoku(EmptyCell(), null))
            {
                MessageBox.Show("There is no solution to this puzzle");
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    uxGrid.Rows[i].Cells[j].Value = _lookup[i, j].Value;
                }
            }


    }

        /// <summary>
        /// Code for editing cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
             Cell[,] _edit = new Cell[8,8];
             _edit = _lookup;
             int lets =0;
            try {
                lets = Convert.ToInt32(uxGrid[e.ColumnIndex, e.RowIndex].Value);
            }
            catch { 
                uxGrid[e.ColumnIndex, e.RowIndex].Value = ' ';
                MessageBox.Show("Number must be between 1 and 9");
                return;
                
             }
            if (lets > 0 && lets < 10)
            {
                _lookup[e.RowIndex, e.ColumnIndex].Value = lets;
            }
            else
            {
            MessageBox.Show("Number must be between 1 and 9");
            uxGrid[e.ColumnIndex, e.RowIndex].Value = ' ';
            }



        }
    }
}

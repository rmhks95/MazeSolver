namespace Ksu.Cis300.Sudoku
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uxPanel = new System.Windows.Forms.Panel();
            this.uxGrid = new System.Windows.Forms.DataGridView();
            this.uxSolve = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAPuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.uxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxPanel
            // 
            this.uxPanel.Controls.Add(this.uxGrid);
            this.uxPanel.Location = new System.Drawing.Point(20, 18);
            this.uxPanel.Margin = new System.Windows.Forms.Padding(2);
            this.uxPanel.Name = "uxPanel";
            this.uxPanel.Size = new System.Drawing.Size(364, 364);
            this.uxPanel.TabIndex = 0;
            // 
            // uxGrid
            // 
            this.uxGrid.AllowUserToAddRows = false;
            this.uxGrid.AllowUserToDeleteRows = false;
            this.uxGrid.AllowUserToResizeColumns = false;
            this.uxGrid.AllowUserToResizeRows = false;
            this.uxGrid.BackgroundColor = System.Drawing.Color.White;
            this.uxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.uxGrid.Location = new System.Drawing.Point(0, 0);
            this.uxGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxGrid.Name = "uxGrid";
            this.uxGrid.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.uxGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.uxGrid.RowTemplate.Height = 28;
            this.uxGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.uxGrid.Size = new System.Drawing.Size(364, 364);
            this.uxGrid.TabIndex = 0;
            this.uxGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxGrid_CellEndEdit);
            // 
            // uxSolve
            // 
            this.uxSolve.Location = new System.Drawing.Point(132, 410);
            this.uxSolve.Name = "uxSolve";
            this.uxSolve.Size = new System.Drawing.Size(137, 35);
            this.uxSolve.TabIndex = 1;
            this.uxSolve.Text = "Solve Puzzle";
            this.uxSolve.UseVisualStyleBackColor = true;
            this.uxSolve.Click += new System.EventHandler(this.uxSolve_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAPuzzleToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // loadAPuzzleToolStripMenuItem
            // 
            this.loadAPuzzleToolStripMenuItem.Name = "loadAPuzzleToolStripMenuItem";
            this.loadAPuzzleToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loadAPuzzleToolStripMenuItem.Text = "Load a Puzzle";
            this.loadAPuzzleToolStripMenuItem.Click += new System.EventHandler(this.loadAPuzzleToolStripMenuItem_Click);
            // 
            // uxOpenFileDialog1
            // 
            this.uxOpenFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 469);
            this.Controls.Add(this.uxSolve);
            this.Controls.Add(this.uxPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Sudoku Solver";
            this.uxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel uxPanel;
        private System.Windows.Forms.DataGridView uxGrid;
        private System.Windows.Forms.Button uxSolve;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAPuzzleToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}


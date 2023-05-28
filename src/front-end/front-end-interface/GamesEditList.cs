using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace Games_In_One
{
    public class GamesEditList : TableLayoutPanel
    {
        private Point mouseDownLocation;
        private Control prev;
        private Control selected; 

        public GamesEditList()
        {
            this.MouseDown += GamesEditList_MouseDown;
            this.MouseMove += GamesEditList_MouseMove;
            this.MouseUp += GamesEditList_MouseUp;
            DoubleBuffered = true;
        }

        // Highlight the selected game row to be white.
        private void GamesEditList_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("In gamesEditList : Mouse down");
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
                selected = this.GetChildAtPoint(mouseDownLocation);
                if (selected != null)
                {
                    selected.BackColor = Color.White;
                }
            }
        }

        // Highlights the current game hovered over by the mouse to be gray.
        private void GamesEditList_MouseMove(object sender, MouseEventArgs e)
        {
            if (prev == null)
            {
                prev = this.GetChildAtPoint(e.Location);
            } else
            {
                if (prev != selected)
                {
                    prev.BackColor = Color.Cyan;
                }
                Control cell = this.GetChildAtPoint(e.Location);
                if (cell != null && cell != selected)
                {
                    cell.BackColor = Color.Gray;
                    prev = cell;
                }
            }
        }

        // After Mousedown on a row, and MouseUp is at a different row
        // swap the locations of the two game rows.
        private void GamesEditList_MouseUp(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("In gamesEditList : Mouse up");
            if (e.Button == MouseButtons.Left && this.RowCount >= 2)
            {
                Debug.WriteLine("In gamesEditList : Mouse left");
                // Gets the cell that I am clicking on when i click
                Control cell = this.GetChildAtPoint(mouseDownLocation);
                if (cell != null)
                {
                    int row = this.GetRow(cell);
                    this.SuspendLayout();


                    GameRow gameRowToSwapWith = (GameRow)this.GetChildAtPoint(e.Location);
                    if (gameRowToSwapWith == null)
                    {
                        Debug.WriteLine("Out of table bound");
                        this.ResumeLayout();
                        return;
                    }
                    int newRow = this.GetRow(gameRowToSwapWith);

                    if (newRow != -1 && (newRow != row))
                    {
                        // Swap the controls
                        int lo = Math.Min(row, newRow);
                        int hi = Math.Max(row, newRow);

                        // Create a list of the controls in the correct order
                        List<GameRow> controls = new List<GameRow>();
                        for (int i = 0; i < this.RowCount; i++)
                        {
                            GameRow control;
                            if (i == lo)
                            {
                                control = (GameRow)(this.GetControlFromPosition(0, hi));
                            }
                            else if (i == hi)
                            {
                                control = (GameRow)(this.GetControlFromPosition(0, lo));
                            }
                            else
                            {
                                control = (GameRow)(this.GetControlFromPosition(0, i));
                            }
                            control.BackColor = Color.Cyan;
                            controls.Add(control);
                        }

                        this.SetCellPosition(controls[lo], new TableLayoutPanelCellPosition(0, lo));
                        this.SetCellPosition(controls[hi], new TableLayoutPanelCellPosition(0, hi));

                        // Remove all controls from the table
                        this.Controls.Clear();

                        // Add controls back to table in new order
                        for (int i = 0; i < this.RowCount; i++)
                        {
                            this.Controls.Add(controls[i]);
                        }
                           
                    }

                    this.ResumeLayout();
                }
            }
            prev = null;
        }
    }
}



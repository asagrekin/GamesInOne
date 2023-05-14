using System.Windows.Forms;
using System.Drawing;
using System;

namespace Games_In_One_App
{
    using System.Drawing;
    using System;
    using System.Windows.Forms;
    using System.Collections.Generic;

    namespace Games_In_One_App
    {
        public class GamesEditList : TableLayoutPanel
        {
            private Point mouseDownLocation;
            private Control prev;
            private Control selected; 
            public GamesEditList()
            {
                this.MouseDown += gamesEditList_MouseDown;
                this.MouseMove += gamesEditList_MouseMove;
                this.MouseUp += gamesEditList_MouseUp;
                DoubleBuffered = true;
            }


            private void gamesEditList_MouseDown(object sender, MouseEventArgs e)
            {
                Console.WriteLine("In gamesEditList : Mouse down");
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

            private void gamesEditList_MouseMove(object sender, MouseEventArgs e)
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
            private void gamesEditList_MouseUp(object sender, MouseEventArgs e)
            {
                Console.WriteLine("In gamesEditList : Mouse up");
                if (e.Button == MouseButtons.Left && this.RowCount >= 2)
                {
                    Console.WriteLine("In gamesEditList : Mouse left");
                    // Gets the cell that I am clicking on when i click
                    Control cell = this.GetChildAtPoint(mouseDownLocation);
                    if (cell != null)
                    {
                        int row = this.GetRow(cell);
                        int col = this.GetColumn(cell);
                        this.SuspendLayout();


                        GameRow gameRowToSwapWith = (GameRow)this.GetChildAtPoint(e.Location);
                        if (gameRowToSwapWith == null)
                        {
                            Console.WriteLine("Out of table bound");
                            this.ResumeLayout();
                            return;
                        }
                        int newRow = this.GetRow(gameRowToSwapWith);

                        //Console.WriteLine(newRow + " *** " + row);
                        if (newRow != -1 && (newRow != row))
                        {

                            //this.Controls.SetChildIndex(cell, newRow * this.ColumnCount + newCol);
                            // Create temporary panel
                            TableLayoutPanel tempPanel = new TableLayoutPanel();
                            tempPanel.Dock = DockStyle.Fill;



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
                                GameRow control = controls[0];
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

}

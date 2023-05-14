using System.Windows.Forms;
using System.Drawing;
using System;

namespace Games_In_One_App
{
    using System.Drawing;
    using System;
    using System.Windows.Forms;

    namespace Games_In_One_App
    {
        public class GameInfoList : TableLayoutPanel
        {
            private Point mouseDownLocation;

            public GameInfoList()
            {
                this.MouseDown += GameInfoList_MouseDown;
                this.MouseMove += GameInfoList_MouseMove;
                this.MouseUp += GameInfoList_MouseUp;
            }

            private void GameInfoList_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseDownLocation = e.Location;
                }
            }

            private void GameInfoList_MouseMove(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int row = this.GetRow(this.GetChildAtPoint(mouseDownLocation));
                    int col = this.GetColumn(this.GetChildAtPoint(mouseDownLocation));

                    if (row != -1 && col != -1)
                    {
                        this.SuspendLayout();

                        Control cell = this.GetControlFromPosition(col, row);
                        this.SetCellPosition(cell, new TableLayoutPanelCellPosition(col, row));

                        int newRow = this.GetRow(this.GetChildAtPoint(e.Location));
                        if (newRow != -1 && newRow != row)
                        {
                            int delta = Math.Sign(newRow - row);
                            this.RowStyles.Insert(newRow + delta, this.RowStyles[row]);
                            this.RowStyles.RemoveAt(row);
                        }

                        this.ResumeLayout();
                    }
                }
            }

            private void GameInfoList_MouseUp(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseDownLocation = Point.Empty;
                }
            }
        }
    }

}

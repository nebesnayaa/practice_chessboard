using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_chessboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Brown, 2);
            float a = 40, b = 40, c = 40;
            bool isParity = false;

            for (int row = 1; row <= 8; row++)
            {
                if (row % 2 == 0)
                    isParity = true;
                else if (row % 2 == 1)
                    isParity = false;

                for (int col = 1; col <= 8; col++)
                {
                    Graphics g = e.Graphics;
                    Graphics ch = e.Graphics;
                    if (isParity)
                    {

                        g.DrawRectangle(pen, a + (col - 1) * c, b, c, c);
                        g.FillRectangle(Brushes.Beige, a + (col - 1) * c, b, c, c);
                        if (row >= 6)
                        {
                            ch.FillEllipse(Brushes.BurlyWood, a + 5 + (col - 1) * c, b + 5, c - 11, c - 11);
                        }
                        isParity = false;
                        continue;
                    }
                    g.DrawRectangle(pen, a + (col - 1) * c, b, c, c);
                    g.FillRectangle(Brushes.Brown, a + (col - 1) * c, b, c, c);
                    if (row <= 3)
                    {
                        ch.FillEllipse(Brushes.Black, a + 5 + (col - 1) * c, b + 5, c - 11, c - 11);
                    }
                    isParity = true;
                }
                b += c;
            }
        }
    }
}
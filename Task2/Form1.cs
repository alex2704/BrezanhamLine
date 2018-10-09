using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Graphics g;
        void Draw(int x1, int y1, int x2, int y2)
        {
            bitmap = new Bitmap(pictureBox.Width,pictureBox.Height);
            g = Graphics.FromImage(bitmap);
            int x = x1;
            int y = y1;
            int Dx = x2 - x1;
            int Dy = y2 - y1;
            int e = 2 * Dy - Dx;
            for (int i = 1; i <= Dx; i++)
            {
                g.FillRectangle(Brushes.Black, x, y, 2, 2);
                if (e >= 0)
                {
                    y++;
                    e += -2 * Dx + 2 * Dy;
                }
                else
                    e += 2 * Dy;
                x++;
            }
            pictureBox.Image = bitmap;
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Draw(50,50,150,150);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando_IRF.Entities
{
    public class Smiley : Label
    {
        public Smiley()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Smiley_Paint;
        }

        private void Smiley_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Yellow), 0, 0, Width, Height);
            g.FillEllipse(new SolidBrush(Color.Red), 15, 15, Width/10, Height/10);
            g.FillEllipse(new SolidBrush(Color.Red), 35, 15, Width/10, Height/10);
            g.FillRectangle(new SolidBrush(Color.Green), 15, 35, 20, 5);
        }
    }
}

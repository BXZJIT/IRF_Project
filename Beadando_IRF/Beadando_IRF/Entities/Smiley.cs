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
        public decimal odd { get; set; }
        public Smiley(decimal odd)
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Smiley_Paint;
            this.odd = odd;
        }

        private void Smiley_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g)
        {
            if (this.odd > 10)
            {
                g.FillEllipse(new SolidBrush(Color.Red), 0, 0, Width, Height);
                g.FillEllipse(new SolidBrush(Color.Yellow), 15, 15, Width / 10, Height / 10);
                g.FillEllipse(new SolidBrush(Color.Yellow), 35, 15, Width / 10, Height / 10);
                g.FillRectangle(new SolidBrush(Color.Yellow), 15, 35, 20, 5);
                

            }
            else
            {
                g.FillEllipse(new SolidBrush(Color.Green), 0, 0, Width, Height);
                g.FillEllipse(new SolidBrush(Color.Red), 15, 15, Width / 10, Height / 10);
                g.FillEllipse(new SolidBrush(Color.Red), 35, 15, Width / 10, Height / 10);
                g.FillRectangle(new SolidBrush(Color.Red), 15, 35, 20, 5);
               

            }
        }
    }
}

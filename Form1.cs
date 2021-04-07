using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UciekającyGuziol
{
    public partial class Form1 : Form
    {
        Random r;
        int punkty;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            punkty = 0;
            CzasZmiany.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveButton();
            punkty = 0;
            toolStripStatusLabel1.Text = "Punkcioszki: " + punkty.ToString();
        }

        private void Guziolek_Click(object sender, EventArgs e)
        {
            MoveButton();
            punkty++;
            toolStripStatusLabel1.Text = "Punkcioszki: " + punkty.ToString();
            CzasZmiany.Stop();
            CzasZmiany.Start();
        }

        private void MoveButton()
        {
            int maxX = this.Size.Width - Guziolek.Size.Width - 50;
            int maxY = this.Size.Height - Guziolek.Size.Height - 50;
            Point p = new Point();
            p.X = r.Next(10, maxX);
            p.Y = r.Next(10, maxY);
            Guziolek.Location = p;
        }
    }
}
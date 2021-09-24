using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelyaevaTank
{
    public partial class FormTank : Form
    {
        private ITransport armoredCar;
        public FormTank()
        {
            InitializeComponent();
        }

        private void Draw() 
        {
            Bitmap bmp = new Bitmap(pictureBoxTanks.Width, pictureBoxTanks.Height);
            Graphics gr = Graphics.FromImage(bmp);
            armoredCar.DrawTransport(gr);
            pictureBoxTanks.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            armoredCar = new ArmoredCar(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black);
            armoredCar.SetPosition(rnd.Next(10,100), rnd.Next(10, 100), pictureBoxTanks.Width, pictureBoxTanks.Height);
            Draw();
        }

        private void buttonCreateTank_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            armoredCar = new Tank(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Green, true, true);
            armoredCar.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTanks.Width, pictureBoxTanks.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e) 
        {
            string name = (sender as Button).Name;
            switch (name) 
            {
                case "buttonUp":
                    armoredCar.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    armoredCar.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    armoredCar.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    armoredCar.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}

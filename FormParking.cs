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
    public partial class FormParking : Form
    {
        private readonly Parking<ArmoredCar> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ArmoredCar>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonParkArmoredCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var armoredCar = new ArmoredCar(100, 1000, dialog.Color);
                if (parking + armoredCar != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonParkTank_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var tank = new Tank(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parking + tank != -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void buttonTakeAway_Click(object sender, EventArgs e)
        {
            if (placeNumber.Text != "") 
            {
                var tank = parking - Convert.ToInt32(placeNumber.Text);
                if (tank != null) 
                {
                    FormTank form = new FormTank();
                    form.SetArmoredCar(tank);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}

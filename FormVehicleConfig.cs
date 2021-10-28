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
    public partial class FormVehicleConfig : Form
    {
        Vehicle vehicle = null;

        private event Action<Vehicle> eventAddVehicle;
        public FormVehicleConfig()
        {
            InitializeComponent();
            panelColorDarkPeach.MouseDown += panelColor_MouseDown;
            panelColorPink.MouseDown += panelColor_MouseDown;
            panelColorPeach.MouseDown += panelColor_MouseDown;
            panelColorViolet.MouseDown += panelColor_MouseDown;
            panelColorPurple.MouseDown += panelColor_MouseDown;
            panelColorDarkPink.MouseDown += panelColor_MouseDown;
            panelColorOrange.MouseDown += panelColor_MouseDown;
            panelColorLightOrange.MouseDown += panelColor_MouseDown;
            buttonDiscard.Click += (object sender, EventArgs e) => { Close(); }; 
        }

        public void AddEvent(Action<Vehicle> ev) 
        {
            if (eventAddVehicle == null)
            {
                eventAddVehicle = new Action<Vehicle>(ev);
            }
            else 
            {
                eventAddVehicle += ev;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e) 
        {
            Panel panel = sender as Panel;
            if (panel == null) return;
            panel.DoDragDrop(panel.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void DrawVehicle() 
        {
            if (vehicle != null) 
            {
                Bitmap bmp = new Bitmap(pictureBoxShowCar.Width, pictureBoxShowCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                vehicle.SetPosition(70, 30, pictureBoxShowCar.Width, pictureBoxShowCar.Height);
                vehicle.DrawTransport(gr);
                pictureBoxShowCar.Image = bmp;
            }
        }

        private void labelArmoredCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelArmoredCar.DoDragDrop(labelArmoredCar.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void labelTank_MouseDown(object sender, MouseEventArgs e)
        {
            labelTank.DoDragDrop(labelTank.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelVehicle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelVehicle_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Бронированная машина":
                    vehicle = new ArmoredCar((int) numericUpDownMaxSpeed.Value, (int) numericUpDownWeight.Value, Color.White);
                    break;
                case "Танк":
                    vehicle = new Tank((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxTower.Checked, checkBoxWeapon.Checked);
                    break;
            }
            DrawVehicle();
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            vehicle.SetMainColor((Color) e.Data.GetData(typeof(Color)));
            DrawVehicle();
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (vehicle is Tank) 
            {
                (vehicle as Tank).SetDopColor((Color)e.Data.GetData(typeof(Color)));
            }
            DrawVehicle();
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            eventAddVehicle?.Invoke(vehicle);
            Close();
        }
    }
}
    
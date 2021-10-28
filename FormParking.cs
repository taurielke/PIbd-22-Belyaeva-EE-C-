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
        private readonly BaseCollection baseCollection;
        public FormParking()
        {
            InitializeComponent();
            baseCollection = new BaseCollection(pictureBoxParking.Width, pictureBoxParking.Height);
        }

        private void ReloadLevels()
        {
            int index = listBoxParkingList.SelectedIndex;
            listBoxParkingList.Items.Clear();

            for (int i = 0; i < baseCollection.Keys.Count; i++)
            {
                listBoxParkingList.Items.Add(baseCollection.Keys[i]);
            }

            if (listBoxParkingList.Items.Count > 0 && (index == -1 || index >= listBoxParkingList.Items.Count))
            {
                listBoxParkingList.SelectedIndex = 0;
            }
            else if (listBoxParkingList.Items.Count > 0 && index > -1 && index < listBoxParkingList.Items.Count)
            {
                listBoxParkingList.SelectedIndex = index;
            }
            else if (listBoxParkingList.Items.Count == 0) 
            {
                pictureBoxParking.Image = null;
            }
        }
        private void Draw()
        {
            if (listBoxParkingList.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                baseCollection[listBoxParkingList.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        private void buttonAddParking_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            baseCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        private void buttonDeleteParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkingList.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxParkingList.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    baseCollection.DelParking(listBoxParkingList.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        private void buttonParkArmoredCar_Click(object sender, EventArgs e)
        {
            if (listBoxParkingList.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var armoredCar = new ArmoredCar (100, 1000, dialog.Color);
                    if (baseCollection[listBoxParkingList.SelectedItem.ToString()] + armoredCar != -1)
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
        private void buttonParkTank_Click(object sender, EventArgs e)
        {
            if (listBoxParkingList.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var tank = new Tank(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        if (baseCollection[listBoxParkingList.SelectedItem.ToString()] + tank != -1)
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
        }
        private void buttonTakeAway_Click(object sender, EventArgs e)
        {
            if (maskedBoxPlaceNumber.Text != "") 
            {
                var tank = baseCollection[listBoxParkingList.SelectedItem.ToString()] - Convert.ToInt32(maskedBoxPlaceNumber.Text);
                if (tank != null) 
                {
                    FormTank form = new FormTank();
                    form.SetArmoredCar(tank);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        private void listBoxParkingList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            var formVehicleConfig = new FormVehicleConfig();
            formVehicleConfig.AddEvent(AddVehicle);
            formVehicleConfig.Show();
        }
        private void AddVehicle(Vehicle vehicle)
        {
            if (vehicle != null && listBoxParkingList.SelectedIndex > -1)
            {
                if ((baseCollection[listBoxParkingList.SelectedItem.ToString()]) + vehicle != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Транспорт не удалось поставить");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (baseCollection.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (baseCollection.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}

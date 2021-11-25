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
using NLog;

namespace BelyaevaTank
{
    public partial class FormParking : Form
    {
        private readonly BaseCollection baseCollection;
        private readonly Logger logger;
        public FormParking()
        {
            InitializeComponent();
            baseCollection = new BaseCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
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
            logger.Info($"Добавили парковку {textBoxNewLevelName.Text}");
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
                    logger.Info($"Удалили парковку {listBoxParkingList.SelectedItem.ToString()}");
                    baseCollection.DelParking(listBoxParkingList.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        
        private void buttonTakeAway_Click(object sender, EventArgs e)
        {
            if (listBoxParkingList.SelectedIndex > -1 && maskedBoxPlaceNumber.Text != "") 
            {
                try
                { 
                    var tank = baseCollection[listBoxParkingList.SelectedItem.ToString()] - Convert.ToInt32(maskedBoxPlaceNumber.Text);
                    if (tank != null)
                    {
                        FormTank form = new FormTank();
                        form.SetArmoredCar(tank);
                        form.ShowDialog();

                        logger.Info($"Изъят автомобиль {tank} с места {maskedBoxPlaceNumber.Text}");
                    }
                    Draw();
                }
                catch (BaseNotFoundException ex) 
                {
                    logger.Warn(ex.Message, "Не найдено");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message, "Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listBoxParkingList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxParkingList.SelectedItem.ToString()}");
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
                try
                {
                    if (((baseCollection[listBoxParkingList.SelectedItem.ToString()]) + vehicle) != -1)
                    {
                        Draw();
                        logger.Info($"Добавлена машина {vehicle}");
                    }
                    else
                    {
                        MessageBox.Show("Машину не удалось поставить");
                    }
                    Draw();
                }
                catch (BaseOverflowException ex)
                {
                    logger.Warn(ex.Message, "Переполнение");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message, "Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    baseCollection.SaveData(saveFileDialog1.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message, "Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    baseCollection.LoadData(openFileDialog1.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog1.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (BaseOccupiedPlaceException ex)
                {
                    logger.Warn(ex.Message, "Занятое место");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message, "Неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

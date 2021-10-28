
namespace BelyaevaTank
{
    partial class FormVehicleConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCarType = new System.Windows.Forms.GroupBox();
            this.labelTank = new System.Windows.Forms.Label();
            this.labelArmoredCar = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxWeapon = new System.Windows.Forms.CheckBox();
            this.checkBoxTower = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelCarWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxShowCar = new System.Windows.Forms.PictureBox();
            this.panelVehicle = new System.Windows.Forms.Panel();
            this.panelColorDarkPeach = new System.Windows.Forms.Panel();
            this.panelColorLightOrange = new System.Windows.Forms.Panel();
            this.panelColorPeach = new System.Windows.Forms.Panel();
            this.panelColorPurple = new System.Windows.Forms.Panel();
            this.panelColorDarkPink = new System.Windows.Forms.Panel();
            this.panelColorPink = new System.Windows.Forms.Panel();
            this.panelColorOrange = new System.Windows.Forms.Panel();
            this.panelColorViolet = new System.Windows.Forms.Panel();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.groupBoxCarType.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowCar)).BeginInit();
            this.panelVehicle.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCarType
            // 
            this.groupBoxCarType.Controls.Add(this.labelTank);
            this.groupBoxCarType.Controls.Add(this.labelArmoredCar);
            this.groupBoxCarType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCarType.Name = "groupBoxCarType";
            this.groupBoxCarType.Size = new System.Drawing.Size(259, 264);
            this.groupBoxCarType.TabIndex = 0;
            this.groupBoxCarType.TabStop = false;
            this.groupBoxCarType.Text = "Тип машины";
            // 
            // labelTank
            // 
            this.labelTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTank.Location = new System.Drawing.Point(21, 139);
            this.labelTank.Name = "labelTank";
            this.labelTank.Size = new System.Drawing.Size(214, 66);
            this.labelTank.TabIndex = 1;
            this.labelTank.Text = "Танк";
            this.labelTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTank_MouseDown);
            // 
            // labelArmoredCar
            // 
            this.labelArmoredCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelArmoredCar.Location = new System.Drawing.Point(21, 29);
            this.labelArmoredCar.Name = "labelArmoredCar";
            this.labelArmoredCar.Size = new System.Drawing.Size(214, 63);
            this.labelArmoredCar.TabIndex = 0;
            this.labelArmoredCar.Text = "Бронированная машина";
            this.labelArmoredCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelArmoredCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelArmoredCar_MouseDown);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxWeapon);
            this.groupBoxParameters.Controls.Add(this.checkBoxTower);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelCarWeight);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 301);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(714, 208);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxWeapon
            // 
            this.checkBoxWeapon.AutoSize = true;
            this.checkBoxWeapon.Location = new System.Drawing.Point(323, 145);
            this.checkBoxWeapon.Name = "checkBoxWeapon";
            this.checkBoxWeapon.Size = new System.Drawing.Size(92, 24);
            this.checkBoxWeapon.TabIndex = 5;
            this.checkBoxWeapon.Text = "Оружие";
            this.checkBoxWeapon.UseVisualStyleBackColor = true;
            // 
            // checkBoxTower
            // 
            this.checkBoxTower.AutoSize = true;
            this.checkBoxTower.Location = new System.Drawing.Point(323, 70);
            this.checkBoxTower.Name = "checkBoxTower";
            this.checkBoxTower.Size = new System.Drawing.Size(86, 24);
            this.checkBoxTower.TabIndex = 4;
            this.checkBoxTower.Text = "Башня";
            this.checkBoxTower.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(21, 145);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(103, 26);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(21, 70);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(103, 26);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelCarWeight
            // 
            this.labelCarWeight.AutoSize = true;
            this.labelCarWeight.Location = new System.Drawing.Point(17, 122);
            this.labelCarWeight.Name = "labelCarWeight";
            this.labelCarWeight.Size = new System.Drawing.Size(107, 20);
            this.labelCarWeight.TabIndex = 1;
            this.labelCarWeight.Text = "Вес машины:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(17, 44);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(203, 20);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Максимальная скорость: ";
            // 
            // pictureBoxShowCar
            // 
            this.pictureBoxShowCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShowCar.Location = new System.Drawing.Point(16, 16);
            this.pictureBoxShowCar.Name = "pictureBoxShowCar";
            this.pictureBoxShowCar.Size = new System.Drawing.Size(404, 218);
            this.pictureBoxShowCar.TabIndex = 2;
            this.pictureBoxShowCar.TabStop = false;
            // 
            // panelVehicle
            // 
            this.panelVehicle.AllowDrop = true;
            this.panelVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVehicle.Controls.Add(this.pictureBoxShowCar);
            this.panelVehicle.Location = new System.Drawing.Point(287, 24);
            this.panelVehicle.Name = "panelVehicle";
            this.panelVehicle.Size = new System.Drawing.Size(439, 252);
            this.panelVehicle.TabIndex = 3;
            this.panelVehicle.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelVehicle_DragDrop);
            this.panelVehicle.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelVehicle_DragEnter);
            // 
            // panelColorDarkPeach
            // 
            this.panelColorDarkPeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelColorDarkPeach.Location = new System.Drawing.Point(194, 95);
            this.panelColorDarkPeach.Name = "panelColorDarkPeach";
            this.panelColorDarkPeach.Size = new System.Drawing.Size(39, 36);
            this.panelColorDarkPeach.TabIndex = 4;
            // 
            // panelColorLightOrange
            // 
            this.panelColorLightOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelColorLightOrange.Location = new System.Drawing.Point(75, 95);
            this.panelColorLightOrange.Name = "panelColorLightOrange";
            this.panelColorLightOrange.Size = new System.Drawing.Size(39, 36);
            this.panelColorLightOrange.TabIndex = 5;
            // 
            // panelColorPeach
            // 
            this.panelColorPeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelColorPeach.Location = new System.Drawing.Point(16, 95);
            this.panelColorPeach.Name = "panelColorPeach";
            this.panelColorPeach.Size = new System.Drawing.Size(39, 36);
            this.panelColorPeach.TabIndex = 5;
            // 
            // panelColorPurple
            // 
            this.panelColorPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelColorPurple.Location = new System.Drawing.Point(136, 157);
            this.panelColorPurple.Name = "panelColorPurple";
            this.panelColorPurple.Size = new System.Drawing.Size(39, 36);
            this.panelColorPurple.TabIndex = 5;
            // 
            // panelColorDarkPink
            // 
            this.panelColorDarkPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelColorDarkPink.Location = new System.Drawing.Point(136, 95);
            this.panelColorDarkPink.Name = "panelColorDarkPink";
            this.panelColorDarkPink.Size = new System.Drawing.Size(39, 36);
            this.panelColorDarkPink.TabIndex = 5;
            // 
            // panelColorPink
            // 
            this.panelColorPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelColorPink.Location = new System.Drawing.Point(75, 157);
            this.panelColorPink.Name = "panelColorPink";
            this.panelColorPink.Size = new System.Drawing.Size(39, 36);
            this.panelColorPink.TabIndex = 5;
            // 
            // panelColorOrange
            // 
            this.panelColorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelColorOrange.Location = new System.Drawing.Point(194, 157);
            this.panelColorOrange.Name = "panelColorOrange";
            this.panelColorOrange.Size = new System.Drawing.Size(39, 36);
            this.panelColorOrange.TabIndex = 5;
            // 
            // panelColorViolet
            // 
            this.panelColorViolet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelColorViolet.Location = new System.Drawing.Point(16, 157);
            this.panelColorViolet.Name = "panelColorViolet";
            this.panelColorViolet.Size = new System.Drawing.Size(39, 36);
            this.panelColorViolet.TabIndex = 5;
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(16, 38);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(98, 42);
            this.labelBaseColor.TabIndex = 6;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(136, 38);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(97, 42);
            this.labelDopColor.TabIndex = 7;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelColorOrange);
            this.groupBoxColors.Controls.Add(this.panelColorDarkPeach);
            this.groupBoxColors.Controls.Add(this.panelColorLightOrange);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.panelColorPurple);
            this.groupBoxColors.Controls.Add(this.labelBaseColor);
            this.groupBoxColors.Controls.Add(this.panelColorViolet);
            this.groupBoxColors.Controls.Add(this.panelColorPeach);
            this.groupBoxColors.Controls.Add(this.panelColorPink);
            this.groupBoxColors.Controls.Add(this.panelColorDarkPink);
            this.groupBoxColors.Location = new System.Drawing.Point(744, 24);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(255, 249);
            this.groupBoxColors.TabIndex = 8;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Location = new System.Drawing.Point(893, 301);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(106, 46);
            this.buttonAddVehicle.TabIndex = 9;
            this.buttonAddVehicle.Text = "Добавить";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Location = new System.Drawing.Point(893, 371);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(106, 48);
            this.buttonDiscard.TabIndex = 10;
            this.buttonDiscard.Text = "Отмена";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            // 
            // FormVehicleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 524);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.buttonAddVehicle);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelVehicle);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.groupBoxCarType);
            this.Name = "FormVehicleConfig";
            this.Text = "FormVehicleConfig";
            this.groupBoxCarType.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowCar)).EndInit();
            this.panelVehicle.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCarType;
        private System.Windows.Forms.Label labelTank;
        private System.Windows.Forms.Label labelArmoredCar;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox checkBoxWeapon;
        private System.Windows.Forms.CheckBox checkBoxTower;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelCarWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxShowCar;
        private System.Windows.Forms.Panel panelVehicle;
        private System.Windows.Forms.Panel panelColorDarkPeach;
        private System.Windows.Forms.Panel panelColorLightOrange;
        private System.Windows.Forms.Panel panelColorPeach;
        private System.Windows.Forms.Panel panelColorPurple;
        private System.Windows.Forms.Panel panelColorDarkPink;
        private System.Windows.Forms.Panel panelColorPink;
        private System.Windows.Forms.Panel panelColorOrange;
        private System.Windows.Forms.Panel panelColorViolet;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.Button buttonDiscard;
    }
}
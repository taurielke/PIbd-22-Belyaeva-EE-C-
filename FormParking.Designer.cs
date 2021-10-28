
namespace BelyaevaTank
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonParkArmoredCar = new System.Windows.Forms.Button();
            this.buttonParkTank = new System.Windows.Forms.Button();
            this.takeTankAway = new System.Windows.Forms.GroupBox();
            this.buttonTakeAway = new System.Windows.Forms.Button();
            this.maskedBoxPlaceNumber = new System.Windows.Forms.MaskedTextBox();
            this.place = new System.Windows.Forms.Label();
            this.listBoxParkingList = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDeleteParking = new System.Windows.Forms.Button();
            this.labelParkings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.takeTankAway.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(-1, -2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1022, 725);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkArmoredCar
            // 
            this.buttonParkArmoredCar.Location = new System.Drawing.Point(1037, 367);
            this.buttonParkArmoredCar.Name = "buttonParkArmoredCar";
            this.buttonParkArmoredCar.Size = new System.Drawing.Size(170, 88);
            this.buttonParkArmoredCar.TabIndex = 1;
            this.buttonParkArmoredCar.Text = "Припарковать бронированную машину";
            this.buttonParkArmoredCar.UseVisualStyleBackColor = true;
            this.buttonParkArmoredCar.Click += new System.EventHandler(this.buttonParkArmoredCar_Click);
            // 
            // buttonParkTank
            // 
            this.buttonParkTank.Location = new System.Drawing.Point(1037, 461);
            this.buttonParkTank.Name = "buttonParkTank";
            this.buttonParkTank.Size = new System.Drawing.Size(170, 69);
            this.buttonParkTank.TabIndex = 2;
            this.buttonParkTank.Text = "Припарковать танк";
            this.buttonParkTank.UseVisualStyleBackColor = true;
            this.buttonParkTank.Click += new System.EventHandler(this.buttonParkTank_Click);
            // 
            // takeTankAway
            // 
            this.takeTankAway.Controls.Add(this.buttonTakeAway);
            this.takeTankAway.Controls.Add(this.maskedBoxPlaceNumber);
            this.takeTankAway.Controls.Add(this.place);
            this.takeTankAway.Location = new System.Drawing.Point(1037, 546);
            this.takeTankAway.Name = "takeTankAway";
            this.takeTankAway.Size = new System.Drawing.Size(170, 163);
            this.takeTankAway.TabIndex = 3;
            this.takeTankAway.TabStop = false;
            this.takeTankAway.Text = "Забрать машину или танк";
            // 
            // buttonTakeAway
            // 
            this.buttonTakeAway.Location = new System.Drawing.Point(23, 117);
            this.buttonTakeAway.Name = "buttonTakeAway";
            this.buttonTakeAway.Size = new System.Drawing.Size(121, 34);
            this.buttonTakeAway.TabIndex = 2;
            this.buttonTakeAway.Text = "Забрать";
            this.buttonTakeAway.UseVisualStyleBackColor = true;
            this.buttonTakeAway.Click += new System.EventHandler(this.buttonTakeAway_Click);
            // 
            // maskedBoxPlaceNumber
            // 
            this.maskedBoxPlaceNumber.Location = new System.Drawing.Point(86, 63);
            this.maskedBoxPlaceNumber.Mask = "00000";
            this.maskedBoxPlaceNumber.Name = "maskedBoxPlaceNumber";
            this.maskedBoxPlaceNumber.Size = new System.Drawing.Size(58, 26);
            this.maskedBoxPlaceNumber.TabIndex = 1;
            this.maskedBoxPlaceNumber.ValidatingType = typeof(int);
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Location = new System.Drawing.Point(19, 69);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(61, 20);
            this.place.TabIndex = 0;
            this.place.Text = "Место:";
            // 
            // listBoxParkingList
            // 
            this.listBoxParkingList.FormattingEnabled = true;
            this.listBoxParkingList.ItemHeight = 20;
            this.listBoxParkingList.Location = new System.Drawing.Point(1047, 103);
            this.listBoxParkingList.Name = "listBoxParkingList";
            this.listBoxParkingList.Size = new System.Drawing.Size(164, 124);
            this.listBoxParkingList.TabIndex = 4;
            this.listBoxParkingList.SelectedIndexChanged += new System.EventHandler(this.listBoxParkingList_SelectedIndexChanged_1);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(1047, 32);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(160, 26);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(1047, 64);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(164, 33);
            this.buttonAddParking.TabIndex = 6;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click_1);
            // 
            // buttonDeleteParking
            // 
            this.buttonDeleteParking.Location = new System.Drawing.Point(1047, 233);
            this.buttonDeleteParking.Name = "buttonDeleteParking";
            this.buttonDeleteParking.Size = new System.Drawing.Size(160, 37);
            this.buttonDeleteParking.TabIndex = 7;
            this.buttonDeleteParking.Text = "Удалить парковку";
            this.buttonDeleteParking.UseVisualStyleBackColor = true;
            this.buttonDeleteParking.Click += new System.EventHandler(this.buttonDeleteParking_Click);
            // 
            // labelParkings
            // 
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(1077, 9);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(86, 20);
            this.labelParkings.TabIndex = 8;
            this.labelParkings.Text = "Парковки:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 721);
            this.Controls.Add(this.labelParkings);
            this.Controls.Add(this.buttonDeleteParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParkingList);
            this.Controls.Add(this.takeTankAway);
            this.Controls.Add(this.buttonParkTank);
            this.Controls.Add(this.buttonParkArmoredCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.takeTankAway.ResumeLayout(false);
            this.takeTankAway.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkArmoredCar;
        private System.Windows.Forms.Button buttonParkTank;
        private System.Windows.Forms.GroupBox takeTankAway;
        private System.Windows.Forms.Button buttonTakeAway;
        private System.Windows.Forms.MaskedTextBox maskedBoxPlaceNumber;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.ListBox listBoxParkingList;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDeleteParking;
        private System.Windows.Forms.Label labelParkings;
    }
}
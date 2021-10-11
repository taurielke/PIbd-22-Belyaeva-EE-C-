
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
            this.placeNumber = new System.Windows.Forms.MaskedTextBox();
            this.place = new System.Windows.Forms.Label();
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
            this.buttonParkArmoredCar.Location = new System.Drawing.Point(1037, 13);
            this.buttonParkArmoredCar.Name = "buttonParkArmoredCar";
            this.buttonParkArmoredCar.Size = new System.Drawing.Size(170, 88);
            this.buttonParkArmoredCar.TabIndex = 1;
            this.buttonParkArmoredCar.Text = "Припарковать бронированную машину";
            this.buttonParkArmoredCar.UseVisualStyleBackColor = true;
            this.buttonParkArmoredCar.Click += new System.EventHandler(this.buttonParkArmoredCar_Click);
            // 
            // buttonParkTank
            // 
            this.buttonParkTank.Location = new System.Drawing.Point(1037, 107);
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
            this.takeTankAway.Controls.Add(this.placeNumber);
            this.takeTankAway.Controls.Add(this.place);
            this.takeTankAway.Location = new System.Drawing.Point(1037, 198);
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
            // placeNumber
            // 
            this.placeNumber.Location = new System.Drawing.Point(86, 63);
            this.placeNumber.Mask = "00000";
            this.placeNumber.Name = "placeNumber";
            this.placeNumber.Size = new System.Drawing.Size(58, 26);
            this.placeNumber.TabIndex = 1;
            this.placeNumber.ValidatingType = typeof(int);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 721);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkArmoredCar;
        private System.Windows.Forms.Button buttonParkTank;
        private System.Windows.Forms.GroupBox takeTankAway;
        private System.Windows.Forms.Button buttonTakeAway;
        private System.Windows.Forms.MaskedTextBox placeNumber;
        private System.Windows.Forms.Label place;
    }
}
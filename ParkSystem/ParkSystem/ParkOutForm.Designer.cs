namespace ParkSystem
{
    partial class ParkOutForm
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parkoutButton = new System.Windows.Forms.Button();
            this.pNumber = new System.Windows.Forms.Label();
            this.vType = new System.Windows.Forms.Label();
            this.vBrand = new System.Windows.Forms.Label();
            this.vSlot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.parkinDate = new System.Windows.Forms.Label();
            this.parkinTime = new System.Windows.Forms.Label();
            this.parkOutDate = new System.Windows.Forms.DateTimePicker();
            this.parkOutTime = new System.Windows.Forms.DateTimePicker();
            this.Duration = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.Controls.Add(this.btnCompute);
            this.bunifuCards1.Controls.Add(this.Duration);
            this.bunifuCards1.Controls.Add(this.parkOutTime);
            this.bunifuCards1.Controls.Add(this.parkOutDate);
            this.bunifuCards1.Controls.Add(this.parkinTime);
            this.bunifuCards1.Controls.Add(this.parkinDate);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.totalAmount);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.vSlot);
            this.bunifuCards1.Controls.Add(this.vBrand);
            this.bunifuCards1.Controls.Add(this.vType);
            this.bunifuCards1.Controls.Add(this.pNumber);
            this.bunifuCards1.Controls.Add(this.parkoutButton);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(22, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(605, 574);
            this.bunifuCards1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Plate Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Slot Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vihicle Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vihicle Type";
            // 
            // parkoutButton
            // 
            this.parkoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkoutButton.FlatAppearance.BorderSize = 0;
            this.parkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkoutButton.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parkoutButton.Image = global::ParkSystem.Properties.Resources.icons8_parking_48;
            this.parkoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkoutButton.Location = new System.Drawing.Point(320, 469);
            this.parkoutButton.Name = "parkoutButton";
            this.parkoutButton.Size = new System.Drawing.Size(179, 44);
            this.parkoutButton.TabIndex = 10;
            this.parkoutButton.Text = "      Park out";
            this.parkoutButton.UseVisualStyleBackColor = true;
            this.parkoutButton.Click += new System.EventHandler(this.parkoutButton_Click);
            // 
            // pNumber
            // 
            this.pNumber.AutoSize = true;
            this.pNumber.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNumber.Location = new System.Drawing.Point(225, 62);
            this.pNumber.Name = "pNumber";
            this.pNumber.Size = new System.Drawing.Size(120, 20);
            this.pNumber.TabIndex = 11;
            this.pNumber.Text = "Plate Number";
            this.pNumber.Click += new System.EventHandler(this.pNumber_Click);
            // 
            // vType
            // 
            this.vType.AutoSize = true;
            this.vType.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vType.Location = new System.Drawing.Point(225, 148);
            this.vType.Name = "vType";
            this.vType.Size = new System.Drawing.Size(120, 20);
            this.vType.TabIndex = 12;
            this.vType.Text = "Plate Number";
            // 
            // vBrand
            // 
            this.vBrand.AutoSize = true;
            this.vBrand.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vBrand.Location = new System.Drawing.Point(225, 253);
            this.vBrand.Name = "vBrand";
            this.vBrand.Size = new System.Drawing.Size(120, 20);
            this.vBrand.TabIndex = 13;
            this.vBrand.Text = "Plate Number";
            // 
            // vSlot
            // 
            this.vSlot.AutoSize = true;
            this.vSlot.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vSlot.Location = new System.Drawing.Point(225, 348);
            this.vSlot.Name = "vSlot";
            this.vSlot.Size = new System.Drawing.Size(120, 20);
            this.vSlot.TabIndex = 14;
            this.vSlot.Text = "Plate Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total:";
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(484, 389);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(19, 20);
            this.totalAmount.TabIndex = 16;
            this.totalAmount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Parkin Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Parkin Time:";
            // 
            // parkinDate
            // 
            this.parkinDate.AutoSize = true;
            this.parkinDate.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkinDate.Location = new System.Drawing.Point(430, 90);
            this.parkinDate.Name = "parkinDate";
            this.parkinDate.Size = new System.Drawing.Size(55, 20);
            this.parkinDate.TabIndex = 19;
            this.parkinDate.Text = "1/1/1";
            // 
            // parkinTime
            // 
            this.parkinTime.AutoSize = true;
            this.parkinTime.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkinTime.Location = new System.Drawing.Point(419, 198);
            this.parkinTime.Name = "parkinTime";
            this.parkinTime.Size = new System.Drawing.Size(100, 20);
            this.parkinTime.TabIndex = 20;
            this.parkinTime.Text = "02:3:34 PM";
            // 
            // parkOutDate
            // 
            this.parkOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.parkOutDate.Location = new System.Drawing.Point(415, 251);
            this.parkOutDate.Name = "parkOutDate";
            this.parkOutDate.Size = new System.Drawing.Size(104, 22);
            this.parkOutDate.TabIndex = 21;
            // 
            // parkOutTime
            // 
            this.parkOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.parkOutTime.Location = new System.Drawing.Point(415, 280);
            this.parkOutTime.Name = "parkOutTime";
            this.parkOutTime.Size = new System.Drawing.Size(104, 22);
            this.parkOutTime.TabIndex = 22;
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(443, 311);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(19, 20);
            this.Duration.TabIndex = 23;
            this.Duration.Text = "0";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(488, 308);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(59, 23);
            this.btnCompute.TabIndex = 24;
            this.btnCompute.Text = "Set";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(338, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Duration";
            // 
            // ParkOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 622);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "ParkOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkOutForm";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button parkoutButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vSlot;
        private System.Windows.Forms.Label vBrand;
        private System.Windows.Forms.Label vType;
        private System.Windows.Forms.Label pNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label parkinTime;
        private System.Windows.Forms.Label parkinDate;
        private System.Windows.Forms.DateTimePicker parkOutTime;
        private System.Windows.Forms.DateTimePicker parkOutDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label Duration;
    }
}
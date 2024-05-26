namespace ParkSystem
{
    partial class ParkinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkinForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ParkInBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.parkinButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PNumberTxtbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SlotscomboBox = new System.Windows.Forms.ComboBox();
            this.VBrandcomboBox = new System.Windows.Forms.ComboBox();
            this.VTypecomboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ParkInBtn);
            this.panel1.Controls.Add(this.DashboardBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 677);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Image = global::ParkSystem.Properties.Resources.icons8_log_out_48;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 621);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "      Log Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Image = global::ParkSystem.Properties.Resources.icons8_cryptocurrency_wallet_48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "       Transactions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Image = global::ParkSystem.Properties.Resources.icons8_carpark_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "      Slots";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ParkInBtn
            // 
            this.ParkInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParkInBtn.FlatAppearance.BorderSize = 0;
            this.ParkInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParkInBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParkInBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ParkInBtn.Image = global::ParkSystem.Properties.Resources.icons8_parking_48;
            this.ParkInBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParkInBtn.Location = new System.Drawing.Point(3, 137);
            this.ParkInBtn.Name = "ParkInBtn";
            this.ParkInBtn.Size = new System.Drawing.Size(204, 44);
            this.ParkInBtn.TabIndex = 3;
            this.ParkInBtn.Text = "      Park In";
            this.ParkInBtn.UseVisualStyleBackColor = true;
            this.ParkInBtn.Click += new System.EventHandler(this.ParkInBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DashboardBtn.Image = global::ParkSystem.Properties.Resources.icons8_dashboard_48;
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 72);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(207, 44);
            this.DashboardBtn.TabIndex = 2;
            this.DashboardBtn.Text = "      Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 69);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Purple;
            this.pictureBox1.Image = global::ParkSystem.Properties.Resources.icons8_garage_48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(108)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(207, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1022, 69);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.bunifuCards1.Controls.Add(this.parkinButton);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.PNumberTxtbox);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.SlotscomboBox);
            this.bunifuCards1.Controls.Add(this.VBrandcomboBox);
            this.bunifuCards1.Controls.Add(this.VTypecomboBox);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(406, 91);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(605, 574);
            this.bunifuCards1.TabIndex = 3;
            // 
            // parkinButton
            // 
            this.parkinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkinButton.FlatAppearance.BorderSize = 0;
            this.parkinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkinButton.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parkinButton.Image = global::ParkSystem.Properties.Resources.icons8_parking_48;
            this.parkinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkinButton.Location = new System.Drawing.Point(320, 469);
            this.parkinButton.Name = "parkinButton";
            this.parkinButton.Size = new System.Drawing.Size(179, 44);
            this.parkinButton.TabIndex = 10;
            this.parkinButton.Text = "      Park ";
            this.parkinButton.UseVisualStyleBackColor = true;
            this.parkinButton.Click += new System.EventHandler(this.parkinButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Plate Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PNumberTxtbox
            // 
            this.PNumberTxtbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.PNumberTxtbox.Location = new System.Drawing.Point(163, 96);
            this.PNumberTxtbox.Name = "PNumberTxtbox";
            this.PNumberTxtbox.Size = new System.Drawing.Size(336, 22);
            this.PNumberTxtbox.TabIndex = 8;
            this.PNumberTxtbox.TextChanged += new System.EventHandler(this.PNumberTxtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose Slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vihicle Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vihicle Type";
            // 
            // SlotscomboBox
            // 
            this.SlotscomboBox.FormattingEnabled = true;
            this.SlotscomboBox.Location = new System.Drawing.Point(167, 430);
            this.SlotscomboBox.Name = "SlotscomboBox";
            this.SlotscomboBox.Size = new System.Drawing.Size(332, 24);
            this.SlotscomboBox.TabIndex = 3;
            this.SlotscomboBox.SelectedIndexChanged += new System.EventHandler(this.SlotscomboBox_SelectedIndexChanged);
            // 
            // VBrandcomboBox
            // 
            this.VBrandcomboBox.FormattingEnabled = true;
            this.VBrandcomboBox.Location = new System.Drawing.Point(167, 310);
            this.VBrandcomboBox.Name = "VBrandcomboBox";
            this.VBrandcomboBox.Size = new System.Drawing.Size(332, 24);
            this.VBrandcomboBox.TabIndex = 2;
            this.VBrandcomboBox.SelectedIndexChanged += new System.EventHandler(this.VBrandcomboBox_SelectedIndexChanged);
            // 
            // VTypecomboBox
            // 
            this.VTypecomboBox.FormattingEnabled = true;
            this.VTypecomboBox.Location = new System.Drawing.Point(167, 201);
            this.VTypecomboBox.Name = "VTypecomboBox";
            this.VTypecomboBox.Size = new System.Drawing.Size(332, 24);
            this.VTypecomboBox.TabIndex = 1;
            this.VTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.VTypecomboBox_SelectedIndexChanged);
            // 
            // ParkinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 677);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParkinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkinForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ParkInBtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.ComboBox SlotscomboBox;
        private System.Windows.Forms.ComboBox VBrandcomboBox;
        private System.Windows.Forms.ComboBox VTypecomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox PNumberTxtbox;
        private System.Windows.Forms.Button parkinButton;
    }
}
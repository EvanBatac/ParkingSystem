namespace ParkSystem
{
    partial class historyList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlateNum = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.ParkDateTime = new System.Windows.Forms.Label();
            this.ParkoutDateTime = new System.Windows.Forms.Label();
            this.Sloc = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlateNum
            // 
            this.PlateNum.AutoSize = true;
            this.PlateNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlateNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlateNum.Location = new System.Drawing.Point(12, 9);
            this.PlateNum.Name = "PlateNum";
            this.PlateNum.Size = new System.Drawing.Size(74, 16);
            this.PlateNum.TabIndex = 0;
            this.PlateNum.Text = "PlateNum";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Type.Location = new System.Drawing.Point(160, 9);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(43, 16);
            this.Type.TabIndex = 1;
            this.Type.Text = "Type";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.ForeColor = System.Drawing.Color.Black;
            this.Brand.Location = new System.Drawing.Point(280, 9);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(48, 16);
            this.Brand.TabIndex = 2;
            this.Brand.Text = "Brand";
            // 
            // ParkDateTime
            // 
            this.ParkDateTime.AutoSize = true;
            this.ParkDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParkDateTime.Location = new System.Drawing.Point(500, 10);
            this.ParkDateTime.Name = "ParkDateTime";
            this.ParkDateTime.Size = new System.Drawing.Size(107, 16);
            this.ParkDateTime.TabIndex = 4;
            this.ParkDateTime.Text = "ParkDateTime";
            this.ParkDateTime.Click += new System.EventHandler(this.label5_Click);
            // 
            // ParkoutDateTime
            // 
            this.ParkoutDateTime.AutoSize = true;
            this.ParkoutDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParkoutDateTime.Location = new System.Drawing.Point(691, 10);
            this.ParkoutDateTime.Name = "ParkoutDateTime";
            this.ParkoutDateTime.Size = new System.Drawing.Size(128, 16);
            this.ParkoutDateTime.TabIndex = 5;
            this.ParkoutDateTime.Text = "ParkoutDateTime";
            this.ParkoutDateTime.Click += new System.EventHandler(this.label6_Click);
            // 
            // Sloc
            // 
            this.Sloc.AutoSize = true;
            this.Sloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sloc.Location = new System.Drawing.Point(411, 9);
            this.Sloc.Name = "Sloc";
            this.Sloc.Size = new System.Drawing.Size(36, 16);
            this.Sloc.TabIndex = 3;
            this.Sloc.Text = "sloc";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.Lime;
            this.Amount.Location = new System.Drawing.Point(922, 7);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(40, 20);
            this.Amount.TabIndex = 6;
            this.Amount.Text = "amt";
            this.Amount.Click += new System.EventHandler(this.label7_Click);
            // 
            // historyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.ParkoutDateTime);
            this.Controls.Add(this.ParkDateTime);
            this.Controls.Add(this.Sloc);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.PlateNum);
            this.Name = "historyList";
            this.Size = new System.Drawing.Size(969, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlateNum;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label ParkDateTime;
        private System.Windows.Forms.Label ParkoutDateTime;
        private System.Windows.Forms.Label Sloc;
        private System.Windows.Forms.Label Amount;
    }
}

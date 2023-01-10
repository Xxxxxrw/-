namespace Parking_Management_System
{
    partial class Stop_Data
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stop_Data));
            this.label2 = new System.Windows.Forms.Label();
            this.CwDGVN1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResetBtn1 = new System.Windows.Forms.Button();
            this.DeleteBtn1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TimetypeTb = new System.Windows.Forms.TextBox();
            this.CarinTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CaroutTb = new System.Windows.Forms.TextBox();
            this.CaratTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SaveBtn1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CarnoTb1 = new System.Windows.Forms.TextBox();
            this.CwnoTb1 = new System.Windows.Forms.TextBox();
            this.UpdateBtn2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CwDGVN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(330, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 12;
            // 
            // CwDGVN1
            // 
            this.CwDGVN1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CwDGVN1.BackgroundColor = System.Drawing.Color.White;
            this.CwDGVN1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CwDGVN1.Location = new System.Drawing.Point(70, 380);
            this.CwDGVN1.Name = "CwDGVN1";
            this.CwDGVN1.ReadOnly = true;
            this.CwDGVN1.RowHeadersVisible = false;
            this.CwDGVN1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.CwDGVN1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CwDGVN1.RowTemplate.Height = 29;
            this.CwDGVN1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CwDGVN1.Size = new System.Drawing.Size(774, 336);
            this.CwDGVN1.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(8, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "车位管理";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.CwDGVN1);
            this.panel1.Controls.Add(this.ResetBtn1);
            this.panel1.Controls.Add(this.DeleteBtn1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TimetypeTb);
            this.panel1.Controls.Add(this.CarinTb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CaroutTb);
            this.panel1.Controls.Add(this.CaratTb);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.SaveBtn1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CarnoTb1);
            this.panel1.Controls.Add(this.CwnoTb1);
            this.panel1.Controls.Add(this.UpdateBtn2);
            this.panel1.Location = new System.Drawing.Point(170, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 747);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ResetBtn1
            // 
            this.ResetBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ResetBtn1.Location = new System.Drawing.Point(593, 224);
            this.ResetBtn1.Name = "ResetBtn1";
            this.ResetBtn1.Size = new System.Drawing.Size(106, 36);
            this.ResetBtn1.TabIndex = 51;
            this.ResetBtn1.Text = "重置";
            this.ResetBtn1.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn1
            // 
            this.DeleteBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DeleteBtn1.Location = new System.Drawing.Point(379, 224);
            this.DeleteBtn1.Name = "DeleteBtn1";
            this.DeleteBtn1.Size = new System.Drawing.Size(106, 36);
            this.DeleteBtn1.TabIndex = 50;
            this.DeleteBtn1.Text = "删除";
            this.DeleteBtn1.UseVisualStyleBackColor = true;
            this.DeleteBtn1.Click += new System.EventHandler(this.DeleteBtn1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(593, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 27);
            this.label11.TabIndex = 43;
            this.label11.Text = "时间类型";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(130, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 27);
            this.label12.TabIndex = 42;
            this.label12.Text = "进入时间";
            // 
            // TimetypeTb
            // 
            this.TimetypeTb.BackColor = System.Drawing.Color.White;
            this.TimetypeTb.Location = new System.Drawing.Point(593, 161);
            this.TimetypeTb.Name = "TimetypeTb";
            this.TimetypeTb.Size = new System.Drawing.Size(126, 27);
            this.TimetypeTb.TabIndex = 41;
            // 
            // CarinTb
            // 
            this.CarinTb.BackColor = System.Drawing.Color.White;
            this.CarinTb.Location = new System.Drawing.Point(130, 161);
            this.CarinTb.Name = "CarinTb";
            this.CarinTb.Size = new System.Drawing.Size(126, 27);
            this.CarinTb.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(369, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 39;
            this.label7.Text = "离开时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(590, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 38;
            this.label8.Text = "在位状态";
            // 
            // CaroutTb
            // 
            this.CaroutTb.BackColor = System.Drawing.Color.White;
            this.CaroutTb.Location = new System.Drawing.Point(369, 161);
            this.CaroutTb.Name = "CaroutTb";
            this.CaroutTb.Size = new System.Drawing.Size(126, 27);
            this.CaroutTb.TabIndex = 37;
            // 
            // CaratTb
            // 
            this.CaratTb.BackColor = System.Drawing.Color.White;
            this.CaratTb.Location = new System.Drawing.Point(590, 67);
            this.CaratTb.Name = "CaratTb";
            this.CaratTb.Size = new System.Drawing.Size(126, 27);
            this.CaratTb.TabIndex = 36;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button4.Location = new System.Drawing.Point(874, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 29);
            this.button4.TabIndex = 35;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaveBtn1
            // 
            this.SaveBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SaveBtn1.Location = new System.Drawing.Point(150, 224);
            this.SaveBtn1.Name = "SaveBtn1";
            this.SaveBtn1.Size = new System.Drawing.Size(106, 36);
            this.SaveBtn1.TabIndex = 19;
            this.SaveBtn1.Text = "保存";
            this.SaveBtn1.UseVisualStyleBackColor = true;
            this.SaveBtn1.Click += new System.EventHandler(this.SaveBtn1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(369, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "车牌号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(130, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "车位号";
            // 
            // CarnoTb1
            // 
            this.CarnoTb1.BackColor = System.Drawing.Color.White;
            this.CarnoTb1.Location = new System.Drawing.Point(369, 67);
            this.CarnoTb1.Name = "CarnoTb1";
            this.CarnoTb1.Size = new System.Drawing.Size(126, 27);
            this.CarnoTb1.TabIndex = 12;
            // 
            // CwnoTb1
            // 
            this.CwnoTb1.BackColor = System.Drawing.Color.White;
            this.CwnoTb1.Location = new System.Drawing.Point(130, 67);
            this.CwnoTb1.Name = "CwnoTb1";
            this.CwnoTb1.Size = new System.Drawing.Size(126, 27);
            this.CwnoTb1.TabIndex = 11;
            // 
            // UpdateBtn2
            // 
            this.UpdateBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UpdateBtn2.Location = new System.Drawing.Point(388, 323);
            this.UpdateBtn2.Name = "UpdateBtn2";
            this.UpdateBtn2.Size = new System.Drawing.Size(140, 48);
            this.UpdateBtn2.TabIndex = 8;
            this.UpdateBtn2.Text = "更新停车信息";
            this.UpdateBtn2.UseVisualStyleBackColor = true;
            this.UpdateBtn2.Click += new System.EventHandler(this.UpdateBtn2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(8, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 39);
            this.label4.TabIndex = 37;
            this.label4.Text = "停车记录";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(8, 696);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 35;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(8, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 39);
            this.label6.TabIndex = 38;
            this.label6.Text = "其他功能";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 747);
            this.panel2.TabIndex = 14;
            // 
            // Stop_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stop_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stop_Data";
            ((System.ComponentModel.ISupportInitialize)(this.CwDGVN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private DataGridView CwDGVN1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private Button ResetBtn1;
        private Button DeleteBtn1;
        private Label label11;
        private Label label12;
        private TextBox TimetypeTb;
        private TextBox CarinTb;
        private Label label7;
        private Label label8;
        private TextBox CaroutTb;
        private TextBox CaratTb;
        private Button button4;
        private Button SaveBtn1;
        private Label label5;
        private Label label1;
        private TextBox CarnoTb1;
        private TextBox CwnoTb1;
        private Button UpdateBtn2;
        private Label label4;
        private Button button2;
        private Label label6;
        private Panel panel2;
    }
}
namespace Parking_Management_System
{
    partial class User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cb = new System.Windows.Forms.ComboBox();
            this.CwDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.CarnoTb1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SaveBtn1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CaroutTb = new System.Windows.Forms.TextBox();
            this.TimetypeTb = new System.Windows.Forms.TextBox();
            this.CarinTb = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CwTb = new System.Windows.Forms.TextBox();
            this.CarcolorTb = new System.Windows.Forms.TextBox();
            this.CarsbTb = new System.Windows.Forms.TextBox();
            this.CarnoTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CwDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(333, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.Cb);
            this.panel1.Controls.Add(this.CwDGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.CarnoTb1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.SaveBtn1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CaroutTb);
            this.panel1.Controls.Add(this.TimetypeTb);
            this.panel1.Controls.Add(this.CarinTb);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CwTb);
            this.panel1.Controls.Add(this.CarcolorTb);
            this.panel1.Controls.Add(this.CarsbTb);
            this.panel1.Controls.Add(this.CarnoTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(173, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 750);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Cb
            // 
            this.Cb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cb.FormattingEnabled = true;
            this.Cb.Items.AddRange(new object[] {
            "1栋",
            "2栋",
            "3栋",
            "4栋",
            "5栋",
            "6栋",
            "7栋",
            "8栋"});
            this.Cb.Location = new System.Drawing.Point(145, 52);
            this.Cb.Name = "Cb";
            this.Cb.Size = new System.Drawing.Size(149, 35);
            this.Cb.TabIndex = 53;
            this.Cb.Text = " 全部分区";
            this.Cb.SelectedIndexChanged += new System.EventHandler(this.Cb_SelectedIndexChanged);
            // 
            // CwDGV
            // 
            this.CwDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CwDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CwDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CwDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CwDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.CwDGV.Location = new System.Drawing.Point(20, 93);
            this.CwDGV.Name = "CwDGV";
            this.CwDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CwDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CwDGV.RowHeadersVisible = false;
            this.CwDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.CwDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.CwDGV.RowTemplate.Height = 29;
            this.CwDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CwDGV.Size = new System.Drawing.Size(463, 643);
            this.CwDGV.TabIndex = 36;
            this.CwDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CwDGV_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Cwno";
            this.Column1.HeaderText = "可用车位";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Cwpace";
            this.Column2.HeaderText = "车位地址";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Gainsboro;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(528, 607);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 27);
            this.label14.TabIndex = 34;
            this.label14.Text = "车牌号(必填)";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // CarnoTb1
            // 
            this.CarnoTb1.BackColor = System.Drawing.Color.White;
            this.CarnoTb1.Location = new System.Drawing.Point(534, 637);
            this.CarnoTb1.Name = "CarnoTb1";
            this.CarnoTb1.Size = new System.Drawing.Size(126, 27);
            this.CarnoTb1.TabIndex = 33;
            this.CarnoTb1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(730, 607);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 27);
            this.label13.TabIndex = 32;
            this.label13.Text = "离开时间(必填)";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(631, 680);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 35);
            this.button3.TabIndex = 31;
            this.button3.Text = "离开";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveBtn1
            // 
            this.SaveBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SaveBtn1.Location = new System.Drawing.Point(743, 451);
            this.SaveBtn1.Name = "SaveBtn1";
            this.SaveBtn1.Size = new System.Drawing.Size(103, 42);
            this.SaveBtn1.TabIndex = 30;
            this.SaveBtn1.Text = "停车";
            this.SaveBtn1.UseVisualStyleBackColor = true;
            this.SaveBtn1.Click += new System.EventHandler(this.SaveBtn1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(534, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 27);
            this.label12.TabIndex = 29;
            this.label12.Text = "车辆离开登记：";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(534, 514);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 27);
            this.label11.TabIndex = 28;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(720, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 27);
            this.label10.TabIndex = 27;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(524, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 27);
            this.label9.TabIndex = 26;
            this.label9.Text = "时间类型(必填：高峰，低谷，一般)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(720, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 27);
            this.label8.TabIndex = 25;
            this.label8.Text = "进入时间(必填)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // CaroutTb
            // 
            this.CaroutTb.BackColor = System.Drawing.Color.White;
            this.CaroutTb.Location = new System.Drawing.Point(730, 637);
            this.CaroutTb.Name = "CaroutTb";
            this.CaroutTb.Size = new System.Drawing.Size(126, 27);
            this.CaroutTb.TabIndex = 23;
            this.CaroutTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TimetypeTb
            // 
            this.TimetypeTb.BackColor = System.Drawing.Color.White;
            this.TimetypeTb.Location = new System.Drawing.Point(530, 385);
            this.TimetypeTb.Name = "TimetypeTb";
            this.TimetypeTb.Size = new System.Drawing.Size(126, 27);
            this.TimetypeTb.TabIndex = 22;
            this.TimetypeTb.TextChanged += new System.EventHandler(this.TimetypeTb_TextChanged);
            // 
            // CarinTb
            // 
            this.CarinTb.BackColor = System.Drawing.Color.White;
            this.CarinTb.Location = new System.Drawing.Point(720, 304);
            this.CarinTb.Name = "CarinTb";
            this.CarinTb.Size = new System.Drawing.Size(126, 27);
            this.CarinTb.TabIndex = 21;
            this.CarinTb.TextChanged += new System.EventHandler(this.CarinTb_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SaveBtn.Location = new System.Drawing.Point(534, 454);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(163, 39);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "首次登记并停车";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(524, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "车位编号(必填)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(534, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "汽车颜色";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(720, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "汽车品牌";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(534, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "车牌号(必填)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CwTb
            // 
            this.CwTb.BackColor = System.Drawing.Color.White;
            this.CwTb.Location = new System.Drawing.Point(530, 304);
            this.CwTb.Name = "CwTb";
            this.CwTb.Size = new System.Drawing.Size(126, 27);
            this.CwTb.TabIndex = 14;
            this.CwTb.TextChanged += new System.EventHandler(this.CwTb_TextChanged);
            // 
            // CarcolorTb
            // 
            this.CarcolorTb.BackColor = System.Drawing.Color.White;
            this.CarcolorTb.Location = new System.Drawing.Point(534, 208);
            this.CarcolorTb.Name = "CarcolorTb";
            this.CarcolorTb.Size = new System.Drawing.Size(126, 27);
            this.CarcolorTb.TabIndex = 13;
            this.CarcolorTb.TextChanged += new System.EventHandler(this.CarcolorTb_TextChanged);
            // 
            // CarsbTb
            // 
            this.CarsbTb.BackColor = System.Drawing.Color.White;
            this.CarsbTb.Location = new System.Drawing.Point(720, 113);
            this.CarsbTb.Name = "CarsbTb";
            this.CarsbTb.Size = new System.Drawing.Size(126, 27);
            this.CarsbTb.TabIndex = 12;
            this.CarsbTb.TextChanged += new System.EventHandler(this.CarsbTb_TextChanged);
            // 
            // CarnoTb
            // 
            this.CarnoTb.BackColor = System.Drawing.Color.White;
            this.CarnoTb.Location = new System.Drawing.Point(534, 113);
            this.CarnoTb.Name = "CarnoTb";
            this.CarnoTb.Size = new System.Drawing.Size(126, 27);
            this.CarnoTb.TabIndex = 11;
            this.CarnoTb.TextChanged += new System.EventHandler(this.CarnoTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(534, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "停车信息登记：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(331, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "更新空车位表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 747);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Gainsboro;
            this.label15.Font = new System.Drawing.Font("华光大标宋_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(26, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 194);
            this.label15.TabIndex = 38;
            this.label15.Text = "否则逢赌必输";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("华光大标宋_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(99, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 194);
            this.label3.TabIndex = 37;
            this.label3.Text = "禁止乱停乱放";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(8, 696);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 35;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1071, 748);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CwDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Button button1;
        private Label label1;
        private TextBox CwTb;
        private TextBox CarcolorTb;
        private TextBox CarsbTb;
        private TextBox CarnoTb;
        private Button SaveBtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button3;
        private Button SaveBtn1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox CaroutTb;
        private TextBox TimetypeTb;
        private TextBox CarinTb;
        private Label label14;
        private TextBox CarnoTb1;
        private Label label13;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button4;
        private DataGridView CwDGV;
        private Label label3;
        private Label label15;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private ComboBox Cb;
    }
}
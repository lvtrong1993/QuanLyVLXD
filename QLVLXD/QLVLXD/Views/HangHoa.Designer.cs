namespace QLVLXD.Views
{
    partial class HangHoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangHoa));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblErrorSL = new System.Windows.Forms.Label();
            this.lblErrorGB = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblErrorGN = new System.Windows.Forms.Label();
            this.lblErrorDVT = new System.Windows.Forms.Label();
            this.lblErrorTenHH = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridviewKH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTimHoaDon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.btnTimKS = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHomeAdd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewKH)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(983, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "x";
            this.toolTip1.SetToolTip(this.label5, "Thoát");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label5_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridviewKH);
            this.panel1.Controls.Add(this.pnMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 506);
            this.panel1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.panel1, "Bán hàng");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.lblErrorSL);
            this.panel2.Controls.Add(this.lblErrorGB);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtGiaBan);
            this.panel2.Controls.Add(this.lblErrorGN);
            this.panel2.Controls.Add(this.lblErrorDVT);
            this.panel2.Controls.Add(this.lblErrorTenHH);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtDVT);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtGiaNhap);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtTenHH);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnHuyBo);
            this.panel2.Controls.Add(this.btnXacNhan);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtMaHH);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Location = new System.Drawing.Point(769, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 448);
            this.panel2.TabIndex = 21;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(129, 312);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(117, 20);
            this.txtSoLuong.TabIndex = 34;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblErrorSL
            // 
            this.lblErrorSL.AutoSize = true;
            this.lblErrorSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSL.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSL.Location = new System.Drawing.Point(252, 312);
            this.lblErrorSL.Name = "lblErrorSL";
            this.lblErrorSL.Size = new System.Drawing.Size(17, 24);
            this.lblErrorSL.TabIndex = 33;
            this.lblErrorSL.Text = "*";
            // 
            // lblErrorGB
            // 
            this.lblErrorGB.AutoSize = true;
            this.lblErrorGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGB.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGB.Location = new System.Drawing.Point(252, 263);
            this.lblErrorGB.Name = "lblErrorGB";
            this.lblErrorGB.Size = new System.Drawing.Size(17, 24);
            this.lblErrorGB.TabIndex = 33;
            this.lblErrorGB.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Số lượng:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(129, 267);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(117, 20);
            this.txtGiaBan.TabIndex = 31;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // lblErrorGN
            // 
            this.lblErrorGN.AutoSize = true;
            this.lblErrorGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGN.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGN.Location = new System.Drawing.Point(252, 219);
            this.lblErrorGN.Name = "lblErrorGN";
            this.lblErrorGN.Size = new System.Drawing.Size(17, 24);
            this.lblErrorGN.TabIndex = 30;
            this.lblErrorGN.Text = "*";
            // 
            // lblErrorDVT
            // 
            this.lblErrorDVT.AutoSize = true;
            this.lblErrorDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDVT.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDVT.Location = new System.Drawing.Point(252, 176);
            this.lblErrorDVT.Name = "lblErrorDVT";
            this.lblErrorDVT.Size = new System.Drawing.Size(17, 24);
            this.lblErrorDVT.TabIndex = 30;
            this.lblErrorDVT.Text = "*";
            // 
            // lblErrorTenHH
            // 
            this.lblErrorTenHH.AutoSize = true;
            this.lblErrorTenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTenHH.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTenHH.Location = new System.Drawing.Point(252, 137);
            this.lblErrorTenHH.Name = "lblErrorTenHH";
            this.lblErrorTenHH.Size = new System.Drawing.Size(17, 24);
            this.lblErrorTenHH.TabIndex = 30;
            this.lblErrorTenHH.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Giá bán:";
            // 
            // txtDVT
            // 
            this.txtDVT.AcceptsReturn = true;
            this.txtDVT.Location = new System.Drawing.Point(129, 176);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(117, 20);
            this.txtDVT.TabIndex = 27;
            this.txtDVT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(53, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Đơn vị tính:";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(129, 218);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(117, 20);
            this.txtGiaNhap.TabIndex = 27;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Giá nhập:";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(129, 137);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(117, 20);
            this.txtTenHH.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tên hàng hóa:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 51);
            this.panel4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bán hàng";
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1021, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "x";
            this.toolTip1.SetToolTip(this.label2, "Thoát");
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Location = new System.Drawing.Point(164, 377);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBo.TabIndex = 22;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Teal;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Location = new System.Drawing.Point(70, 377);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 21;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Location = new System.Drawing.Point(48, 353);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(210, 2);
            this.label26.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(288, -172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(2, 650);
            this.label10.TabIndex = 18;
            this.label10.Text = "label10";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(4, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(700, 2);
            this.label4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(700, 2);
            this.label6.TabIndex = 16;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(129, 86);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.Size = new System.Drawing.Size(117, 20);
            this.txtMaHH.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(702, -162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 465);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(0, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 2);
            this.label8.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 465);
            this.label9.TabIndex = 4;
            this.label9.Text = "label9";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(43, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 18;
            this.label25.Text = "Mã hàng hóa:";
            // 
            // dataGridviewKH
            // 
            this.dataGridviewKH.BackgroundColor = System.Drawing.Color.White;
            this.dataGridviewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridviewKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dataGridviewKH.Location = new System.Drawing.Point(61, 55);
            this.dataGridviewKH.Name = "dataGridviewKH";
            this.dataGridviewKH.Size = new System.Drawing.Size(705, 447);
            this.dataGridviewKH.TabIndex = 20;
            this.dataGridviewKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridviewKH_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "DVT";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá nhập";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá bán";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số lượng";
            this.Column7.Name = "Column7";
            this.Column7.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cập nhật";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Xóa HH";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.pnMenu.Controls.Add(this.button4);
            this.pnMenu.Controls.Add(this.btnMenu);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Controls.Add(this.btnThoat);
            this.pnMenu.Controls.Add(this.button3);
            this.pnMenu.Controls.Add(this.btnTimHoaDon);
            this.pnMenu.Controls.Add(this.button2);
            this.pnMenu.Controls.Add(this.btnThongKe);
            this.pnMenu.Controls.Add(this.btnLapHoaDon);
            this.pnMenu.Controls.Add(this.btnTimKS);
            this.pnMenu.Controls.Add(this.label40);
            this.pnMenu.Controls.Add(this.label38);
            this.pnMenu.Controls.Add(this.label35);
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(55, 526);
            this.pnMenu.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(2, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 49);
            this.button4.TabIndex = 21;
            this.button4.Text = "Kho hàng";
            this.toolTip1.SetToolTip(this.button4, "Kho hàng");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(1, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(201, 49);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(2, 69);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(201, 49);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Bán hàng";
            this.toolTip1.SetToolTip(this.btnHome, "Bán hàng");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1, 456);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(201, 49);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(2, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "Nhân viên";
            this.toolTip1.SetToolTip(this.button3, "Nhân viên");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTimHoaDon
            // 
            this.btnTimHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.btnTimHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnTimHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnTimHoaDon.Image")));
            this.btnTimHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimHoaDon.Location = new System.Drawing.Point(2, 312);
            this.btnTimHoaDon.Name = "btnTimHoaDon";
            this.btnTimHoaDon.Size = new System.Drawing.Size(201, 49);
            this.btnTimHoaDon.TabIndex = 6;
            this.btnTimHoaDon.Text = "Hóa đơn";
            this.toolTip1.SetToolTip(this.btnTimHoaDon, "Hóa đơn chứng từ");
            this.btnTimHoaDon.UseVisualStyleBackColor = false;
            this.btnTimHoaDon.Click += new System.EventHandler(this.btnTimHoaDon_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(2, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thống kê";
            this.toolTip1.SetToolTip(this.button2, "Thống kê");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(2, 264);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(201, 49);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Nhà cung cấp";
            this.toolTip1.SetToolTip(this.btnThongKe, "Nhà cung cấp");
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.btnLapHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnLapHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnLapHoaDon.Image")));
            this.btnLapHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHoaDon.Location = new System.Drawing.Point(2, 216);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(201, 49);
            this.btnLapHoaDon.TabIndex = 6;
            this.btnLapHoaDon.Text = "Khách hàng";
            this.toolTip1.SetToolTip(this.btnLapHoaDon, "Khách hàng");
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // btnTimKS
            // 
            this.btnTimKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.btnTimKS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKS.ForeColor = System.Drawing.Color.White;
            this.btnTimKS.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKS.Image")));
            this.btnTimKS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKS.Location = new System.Drawing.Point(2, 120);
            this.btnTimKS.Name = "btnTimKS";
            this.btnTimKS.Size = new System.Drawing.Size(201, 49);
            this.btnTimKS.TabIndex = 6;
            this.btnTimKS.Text = "Nhập hàng";
            this.toolTip1.SetToolTip(this.btnTimKS, "Nhập hàng");
            this.btnTimKS.UseVisualStyleBackColor = false;
            this.btnTimKS.Click += new System.EventHandler(this.btnTimKS_Click);
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label40.Location = new System.Drawing.Point(0, 169);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(200, 1);
            this.label40.TabIndex = 18;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label38.Location = new System.Drawing.Point(1, 118);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(200, 1);
            this.label38.TabIndex = 18;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(1, 67);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(200, 1);
            this.label35.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.lblHomeAdd);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(54, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 51);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // lblHomeAdd
            // 
            this.lblHomeAdd.AutoSize = true;
            this.lblHomeAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHomeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHomeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeAdd.ForeColor = System.Drawing.Color.White;
            this.lblHomeAdd.Location = new System.Drawing.Point(428, 17);
            this.lblHomeAdd.Name = "lblHomeAdd";
            this.lblHomeAdd.Size = new System.Drawing.Size(119, 24);
            this.lblHomeAdd.TabIndex = 15;
            this.lblHomeAdd.Text = "KHO HÀNG";
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 515);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HangHoa";
            this.Text = "HangHoa";
            this.Load += new System.EventHandler(this.HangHoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewKH)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTimHoaDon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnTimKS;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHomeAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblErrorGN;
        private System.Windows.Forms.Label lblErrorDVT;
        private System.Windows.Forms.Label lblErrorTenHH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridviewKH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblErrorGB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblErrorSL;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}
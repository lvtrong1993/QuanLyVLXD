using QLVLXD.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVLXD.Views
{
    public partial class NhaCungCap : Form
    {
        private int Col_Update = 4;
        private int Col_Delete = 5;
        private NhaCungCapController controller;
        private static int x, y;
        public NhaCungCap()
        {
            InitializeComponent();
            controller = new NhaCungCapController();
        }

        private void NHACC_Load(object sender, EventArgs e)
        {
            _loadDataView();
        }

        private void _loadDataView()
        {
            dataGridView1.Rows.Clear();

            var ks = controller.getDataLoadView();
            for (int i = 0; i < ks.Count(); i++)
            {
                dataGridView1.Rows.Add(ks[i].MANCC, ks[i].TENNCC, ks[i].SDT, ks[i].DIACHI, "Cập nhật", "Xóa");
            }
        }

        /**
         * Catch event click on GridView control to handle update or delete item
         * 
        **/
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int id = 0;
            try
            {
                id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                //Click edit
                if (col == Col_Update)
                {
                    var nv = controller.loadDataEdit(id);
                    txtMaKH.Text = nv.MANCC.ToString();
                    txtTenKH.Text = nv.TENNCC;
                    txtDiaChi.Text = nv.DIACHI;
                    txtSDT.Text = nv.SDT.ToString();
                }
                //Click delete
                if (col == Col_Delete)
                {
                    if (controller.delete(id))
                    {
                        MessageBox.Show("Deleted NV has id: " + id);
                        _loadDataView();
                    }
                }
            }
            catch { }
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (_validInput())
            {
                QLVLXD.Models.Entities.NHACC nv = new QLVLXD.Models.Entities.NHACC();
                try
                {
                    int id = int.Parse(txtMaKH.Text);
                    nv.MANCC = int.Parse(txtMaKH.Text);
                    nv.TENNCC = txtTenKH.Text;
                    nv.SDT = int.Parse(txtSDT.Text);
                    nv.DIACHI = txtDiaChi.Text;

                    if (id > 0)
                    {
                        if (controller.updateItem(nv))
                        {
                            MessageBox.Show("Updated item has id: " + id);
                            _loadDataView();
                        }
                    }
                    else
                    {
                        if (controller.addItem(nv))
                        {
                            MessageBox.Show("Added item");
                            _clearForm();
                            _loadDataView();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _clearForm();
        }

        private void _clearForm()
        {
            txtDiaChi.Text = null;
            txtMaKH.Text = "0";
            txtSDT.Text = null;
            txtTenKH.Text = null;
        }

        private bool _validInput()
        {
            if (txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Fileds aren't empty");
                return false;
            }
            else
            {
                int n;
                bool isNumeric = int.TryParse(txtSDT.Text, out n);
                if (!isNumeric)
                {
                    MessageBox.Show("Value must numeric");
                    return false;
                }
            }

            return true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home nh = new Home();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
        }

        private void btnTimKS_Click(object sender, EventArgs e)
        {
            NhapHang nh = new NhapHang();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            KhachHang nh = new KhachHang();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            NhaCungCap nh = new NhaCungCap();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
        }

        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonChungTu nh = new HoaDonChungTu();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.Show();
            int x = this.DesktopBounds.Left + (this.Width - tk.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - tk.Height) / 2;
            tk.SetDesktopLocation(x, y);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhanVien nh = new NhanVien();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Đăng xuất?.", "Title", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Session.nhanvien = null;
                Form1 lg = new Form1();
                lg.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HangHoa nh = new HangHoa();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetDesktopLocation(MousePosition.X - x - panel3.Location.X - Screen.PrimaryScreen.WorkingArea.X, MousePosition.Y - y - panel3.Location.Y - Screen.PrimaryScreen.WorkingArea.Y);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thoát chương trình?.", "Title", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
    }
}

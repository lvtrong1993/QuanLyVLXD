using QLVLXD.Controllers;
using QLVLXD.Models.Entities;
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
    public partial class HangHoa : Form
    {
        private static int x, y;
        private HangHoaController hC = new HangHoaController();
        private bool flagUpdate =false;
        public HangHoa()
        {
            InitializeComponent();
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            lblErrorDVT.Text = "";
            lblErrorGB.Text = "";
            lblErrorGN.Text = "";
            lblErrorSL.Text = "";
            lblErrorTenHH.Text = "";
            loadData();

        }
         private void loadData()
        {
            List<HANGHOA> hh = hC.getAllHH();
            if (hh != null)
            {
                dataGridviewKH.Rows.Clear();
               
               
                for (int i = 0; i < hh.Count; i++)
                {
                    dataGridviewKH.Rows.Add(hh[i].MAHH.ToString(), hh[i].TENHH,hh[i].DONVITINH, hh[i].GIANHAP.ToString(), hh[i].DONGIA, hh[i].SOLUONGTON, "Sửa", "Xóa");
                }
            }
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool flagEmptyForm = checkEmptyForm();
            if (flagEmptyForm == true)
            {
                //  string strMaHH = txtMaHH.Text;
                string strGiaNhap = txtGiaNhap.Text;
                string strGiaBan = txtGiaBan.Text;
                string strSL = txtSoLuong.Text;
                //  int maHH = Int32.Parse(strMaHH);
                string tenHH = txtTenHH.Text;
                string dvt = txtDVT.Text;
                int giaNhap = Int32.Parse(strGiaNhap);
                int giaBan = Int32.Parse(strGiaBan);
                int sl = Int32.Parse(strSL);
                if (flagUpdate == false)
                {
                    bool checkAddHH = hC.addHH(tenHH, dvt, giaNhap, giaBan, sl);
                    if (checkAddHH == true)
                    {
                        MessageBox.Show("Thêm hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();

                    }
                    else
                    {
                        MessageBox.Show("Thêm mới khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    string strMaHH = txtMaHH.Text;
                    

                    int maHH = Int32.Parse(strMaHH);
                    bool checkUpdateHH = hC.updateHangHoa(maHH, tenHH, dvt, giaNhap, giaBan, sl);
                    if (checkUpdateHH == true)
                    {
                        MessageBox.Show("Cập nhật hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mới khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }else
            {
                MessageBox.Show("Thiếu thông tin, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            flagUpdate = false;
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridviewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                txtMaHH.Text = dataGridviewKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenHH.Text = dataGridviewKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDVT.Text = dataGridviewKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaNhap.Text = dataGridviewKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGiaBan.Text = dataGridviewKH.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoLuong.Text = dataGridviewKH.Rows[e.RowIndex].Cells[5].Value.ToString();
                flagUpdate = true;

            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                string strIdHH = dataGridviewKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idHH  = Int32.Parse(strIdHH);
                
              //  if(chkDeleteHH == true)
                {
                    DialogResult dr = MessageBox.Show("Xóa mặt hàng?.", "Xác nhận", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        bool chkDeleteHH = hC.deleteHH(idHH);
                        loadData();
                    }
                }
            }
        }
        public bool checkEmptyForm()
        {
            bool flagCheck = true;
            if (string.IsNullOrWhiteSpace(txtTenHH.Text))
            {
                flagCheck = false;
                lblErrorTenHH.Text = "*";
            }
            else
            {
                lblErrorTenHH.Text = "";
            }
            if (string.IsNullOrWhiteSpace(txtDVT.Text))
            {
                flagCheck = false;
                lblErrorDVT.Text = "*";
            }
            else
            {
                lblErrorDVT.Text = "";
            }
            if (string.IsNullOrWhiteSpace(txtGiaNhap.Text))
            {
                flagCheck = false;
                lblErrorGN.Text = "*";
            }
            else
            {
                lblErrorGN.Text = "";
            }
            if (string.IsNullOrWhiteSpace(txtGiaBan.Text))
            {
                flagCheck = false;
                lblErrorGB.Text = "*";
            }
            else
            {
                lblErrorGB.Text = "";
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                flagCheck = false;
                lblErrorSL.Text = "*";
            }
            else
            {
                lblErrorSL.Text = "";
            }

            if (flagCheck == true)
                return true;
            return false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            HangHoa nh = new HangHoa();
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

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thoát chương trình?.", "Title", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label5_Click(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class KhachHang : Form
    {
        private static int x, y;
        KhachHangController khController = new KhachHangController();
        private bool checkUpdate =false;
        public KhachHang()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadData(bool addButton)
        {
            dataGridviewKH.Rows.Clear();
            List<KHACHHANG> kh = khController.dsKhachHang();
            // DataTable table = new DataTable();
            /* table.Columns.Add("Mã khách hàng", typeof(int));
             table.Columns.Add("Tên khách hàng", typeof(string));
             table.Columns.Add("SĐT", typeof(int));
             table.Columns.Add("Địa chỉ", typeof(string));*/
            for (int i = 0; i < kh.Count; i++)
            {
                dataGridviewKH.Rows.Add(kh[i].MAKH.ToString(), kh[i].TENKH, kh[i].SDT.ToString(), kh[i].DIACHI, "Sửa", "Xóa");
            }
            //

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            lblErrorDC.Text = "";
            lblErrorSDT.Text = "";
            lblErrorTenKH.Text = "";
            LoadData(true);
            

        }

        private void dataGridviewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex== 4)
            {

                    txtMaKH.Text=dataGridviewKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenKH.Text=dataGridviewKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSDT.Text = dataGridviewKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDiaChi.Text = dataGridviewKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                    checkUpdate = true;

            }else
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    try
                    {
                        int makh = Int32.Parse(dataGridviewKH.Rows[e.RowIndex].Cells[0].Value.ToString());
                        DialogResult dr = MessageBox.Show("Xóa khách hàng?. ", "Title", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            bool c = khController.deleteKH(makh);
                            if (c)
                            {
                                MessageBox.Show("Xóa khách hàng thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData(false);
                            }else
                            {
                                MessageBox.Show("Xóa khách hàng thất bại", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thất bại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("test" + e.RowIndex.ToString() + e.ColumnIndex.ToString(), "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool CheckEmptyForm()
        {
            bool flagCheck = true;
            string tenkh = txtTenKH.Text;
            string sdt = txtSDT.Text;
            string dc = txtDiaChi.Text;

            if (string.IsNullOrWhiteSpace(tenkh))
            {
                flagCheck = false;
                lblErrorTenKH.Text = "*";
            }
            else
            {
                lblErrorTenKH.Text = "";
            }
            if (string.IsNullOrWhiteSpace(sdt))
            {
                flagCheck = false;
                lblErrorSDT.Text = "*";
            }
            else
            {
                lblErrorSDT.Text = "";
            }
            if (string.IsNullOrWhiteSpace(dc))
            {
                flagCheck = false;
                lblErrorDC.Text = "*";
            }
            else
            {
                lblErrorDC.Text = "";
            }
            if (flagCheck == false)
                return false;
            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (checkUpdate == true)
            {

                bool checkEmpty = CheckEmptyForm();
                if (checkEmpty == true)
                {
                    // gọi hàm update khách hàng
                    try
                    {
                        int makh = Int32.Parse(txtMaKH.Text);
                        string tenkh = txtTenKH.Text;
                        int sdt = Int32.Parse(txtSDT.Text);
                        string diachi = txtDiaChi.Text;
                        bool check = khController.updateKH(makh, tenkh, sdt, diachi);
                        if (check)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                         //   dataGridviewKH.Rows.Clear();
                           // dataGridviewKH.Refresh();
                            LoadData(false);
                            txtMaKH.Text = "";
                            txtTenKH.Text = "";
                            txtSDT.Text = "";
                            txtDiaChi.Text = "";
                        }
                        checkUpdate = false;
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi, vui lòng kiểm tra lại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin, vui lòng kiểm tra lại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                bool checkEmpty = CheckEmptyForm();
                if (checkEmpty == true)
                {
                    // gọi hàm update khách hàng
                    try
                    {
                        int makh = 1;
                        string tenkh = txtTenKH.Text;
                        int sdt = Int32.Parse(txtSDT.Text);
                        string diachi = txtDiaChi.Text;
                        bool check = khController.addKH(makh, tenkh, sdt, diachi);
                        if (check)
                        {
                            MessageBox.Show("Thêm mới khách hàng thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(false);
                            txtMaKH.Text = "";
                            txtTenKH.Text = "";
                            txtSDT.Text = "";
                            txtDiaChi.Text = "";
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi, vui lòng kiểm tra lại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin, vui lòng kiểm tra lại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}

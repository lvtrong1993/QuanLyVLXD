using QLVLXD.Controllers;
using QLVLXD.Models.Entities;
using QLVLXD.Models.ViewModels;
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
    public partial class HoaDonChungTu : Form
    {
        private static int x, y;
        HoaDonChungTuController hdctController = new HoaDonChungTuController();
        private List<CTHDModel> ct;
        private List<CTPNModel> ctpn;
        private bool flagHD = true;
        public HoaDonChungTu()
        {
            InitializeComponent();
        }

        private void radHoaDon_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewHDCT.Columns[0].HeaderText = "Số HD";
            dataGridViewHDCT.Columns[1].HeaderText = "Tên KH";
            lblTen.Text = "Tên KH";
            flagHD = true;
            loadData();
        }

        private void radPhieuNhap_CheckedChanged(object sender, EventArgs e)
        {
            flagHD = false;
            dataGridViewHDCT.Columns[0].HeaderText = "Số PN";
            dataGridViewHDCT.Columns[1].HeaderText = "Tên NCC";
            lblTen.Text = "Tên NCC";
            loadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadData()
        {
            dataGridViewHDCT.Rows.Clear();
            if (flagHD)
            {
                List<HoaDonModel> hd = hdctController.listHD();
                for (int i = 0; i < hd.Count; i++)
                {
                    dataGridViewHDCT.Rows.Add(hd[i].SOHD.ToString(), hd[i].TENKH, hd[i].NGAYLAP.ToString(), hd[i].TENNVLAP, hd[i].TONGTIEN.ToString(), "Xem", "Xóa");
                    //dataGridViewHDCT.Rows.Add(hd[i].SOHD.ToString(), hd[i].MAKH.ToString(), hd[i].NGAYLAP.ToString(), hd[i].NVLAP.ToString(),hd[i].TONGTIEN.ToString(),"Sửa", "Xóa");
                }
            }
            else
            {
                List<PhieuNhapModel> pn = hdctController.listPN();
                for (int i = 0; i < pn.Count; i++)
                {
                    dataGridViewHDCT.Rows.Add(pn[i].SOPN.ToString(), pn[i].TENNCC, pn[i].NGAYNHAP.ToString(), pn[i].TENNVLAP, pn[i].TONGTIEN.ToString(), "Xem", "Xóa");
                }
            }
        }

        private void dataGridViewHDCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 5)
            {


                if (panel2.Width != 0)
                {
                    panel2.Width = 0;
                    while (dataGridViewHDCT.Width < 997)
                        dataGridViewHDCT.Width++;
                }
                else
                {
                    while (dataGridViewHDCT.Width > 513)
                        dataGridViewHDCT.Width--;
                    panel2.Width = 484;


                }
                // if (flagHD)
                {
                    txtTen.Text = dataGridViewHDCT.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtNgayLap.Text = dataGridViewHDCT.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtNhanVienLap.Text = dataGridViewHDCT.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtTongTien.Text = dataGridViewHDCT.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string HD = dataGridViewHDCT.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(HD);

                    // MessageBox.Show(cc.ToString(), "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (flagHD)
                    {
                        ct = hdctController.getListCTHDByHD(id);
                        int cc = ct.Count;
                        loadDataCT(true);
                    }
                    else
                    {
                        ctpn = hdctController.getListCTPNByPN(id);
                        loadDataCT(false);
                    }
                }

            }
            else
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 6)
                {
                    if (flagHD)
                    {
                        // xóa HD
                        DialogResult dr = MessageBox.Show("Xóa hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dr == DialogResult.Yes)
                        {
                            string HD = dataGridViewHDCT.Rows[e.RowIndex].Cells[0].Value.ToString();
                            int maHD = Convert.ToInt32(HD);
                         //   MessageBox.Show("Xóa "+maHD, "Thông báo");

                            bool d = hdctController.deleteHD(maHD);
                            if (d)
                            {
                                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                                loadData();

                            }else {
                                MessageBox.Show("Lỗi", "Thông báo");

                            }
                        }

                    }
                    else
                    {
                        // xóa HD
                        DialogResult dr = MessageBox.Show("Bạn muốn xóa phiếu nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dr == DialogResult.Yes)
                        {
                            string HD = dataGridViewHDCT.Rows[e.RowIndex].Cells[0].Value.ToString();
                            int mapn = Convert.ToInt32(HD);
                            bool d = hdctController.deletePN(mapn);
                            if (d)
                            {
                                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                                loadData();

                            }
                        }
                    }
                }
            }
        }
        private void loadDataCT(bool chkHD)
        {
            if (chkHD == true)
            {
                dataGridViewChiTiet.Rows.Clear();
                for (int i = 0; i < ct.Count; i++)
                {
                    dataGridViewChiTiet.Rows.Add(ct[i].MAHH, ct[i].TENHH, ct[i].SOLUONG, ct[i].DONGIA);
                }
            }
            else
            {
                dataGridViewChiTiet.Rows.Clear();
                for (int i = 0; i < ctpn.Count; i++)
                {
                    dataGridViewChiTiet.Rows.Add(ctpn[i].MAHH, ctpn[i].TENHH, ctpn[i].SOLUONGNHAP, ctpn[i].GIANHAP);
                }
            }
        }
        private void HoaDonChungTu_Load(object sender, EventArgs e)
        {
            loadData();
            panel2.Width = 0;
            txtTen.Enabled = false;
            txtTongTien.Enabled = false;
            txtNhanVienLap.Enabled = false;
            txtNgayLap.Enabled = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDong_Click(object sender, EventArgs e)
        {

            if (panel2.Width != 0)
            {
                panel2.Width = 0;
                while (dataGridViewHDCT.Width < 997)
                    dataGridViewHDCT.Width++;
            }
            else
            {
                while (dataGridViewHDCT.Width > 513)
                    dataGridViewHDCT.Width--;
                panel2.Width = 484;


            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhanVienLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKS_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {

        }

        private void lblHomeAdd_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Home nh = new Home();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
        }

        private void btnTimKS_Click_1(object sender, EventArgs e)
        {
            NhapHang nh = new NhapHang();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();

        }

        private void btnLapHoaDon_Click_1(object sender, EventArgs e)
        {
            KhachHang nh = new KhachHang();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            NhaCungCap nh = new NhaCungCap();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
        }

        private void btnTimHoaDon_Click_1(object sender, EventArgs e)
        {
            HoaDonChungTu nh = new HoaDonChungTu();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.Show();
            int x = this.DesktopBounds.Left + (this.Width - tk.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - tk.Height) / 2;
            tk.SetDesktopLocation(x, y);
            this.Close();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            NhanVien nh = new NhanVien();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();


        }

        private void btnThoat_Click_1(object sender, EventArgs e)
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

        private void label11_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thoát chương trình?.", "Title", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

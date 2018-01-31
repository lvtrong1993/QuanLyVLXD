using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace QLVLXD.Views
{
    public partial class ThongKe : Form
    {

        private static int x, y;
        public ThongKe()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cHITIETPNBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            if (rdHoaDon.Checked)
            {
                if (dtpNgayBD.Value >= dtpNgayKT.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc","Thông báo");
                }
                else
                {
                    String sql = "Select * from HoaDon Where NgayLap >='" + dtpNgayBD.Value.ToString() + "'and NgayLap <='" + dtpNgayKT.Value.ToString() + "'";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data source=TRONG-PC\SQLEXPRESS113;initial catalog=QLVLXD;user id=sa;password=trong1993 ";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportPath = "D:/HocTap/HCMUS/PTPM/DoanThanh/DoAn/QLVLXD/QLVLXD/Views/Report1.rdlc";
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReportDataSource rds = new ReportDataSource();
                        rds.Name = "DataSet1";
                        rds.Value = ds.Tables[0];
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.RefreshReport();

                    }


                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        MessageBox.Show("Không có dữ liệu cần tìm", "Thông báo");
                    }
                }
            }
            else if(rdPhieuNhap.Checked)
            {
                if (dtpNgayBD.Value >= dtpNgayKT.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo");
                }
                else
                {
                    String sql = "Select * from PhieuNhap Where NgayNhap >='" + dtpNgayBD.Value.ToString() + "' and NgayNhap <='" + dtpNgayKT.Value.ToString() + "'";
                    SqlConnection con = new SqlConnection();
                
                    con.ConnectionString = @"Data source=TRONG-PC\SQLEXPRESS113;initial catalog=QLVLXD;user id=sa;password=trong1993";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);

                  
                    reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                
                    reportViewer1.LocalReport.ReportPath = "D:/HocTap/HCMUS/PTPM/DoanThanh/DoAn/QLVLXD/QLVLXD/Views/Report1.rdlc";
                
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReportDataSource rds = new ReportDataSource();
                        rds.Name = "DataSet1";
                        rds.Value = ds.Tables[0];
                        reportViewer1.LocalReport.DataSources.Clear();                   
                        reportViewer1.LocalReport.DataSources.Add(rds);           
                        reportViewer1.RefreshReport();
                    }
                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        MessageBox.Show("Không có dữ liệu cần tìm", "Thông báo");
                    }
                }
            }

            else{
                MessageBox.Show("Bạn chưa chọn chỉ mục cần thống kê","Thông báo");
            }


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void btnTimKS_Click(object sender, EventArgs e)
        {
            NhapHang nh = new NhapHang();
            nh.Show();
            this.Close();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.Show();
            this.Close();
        }

        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonChungTu hdct = new HoaDonChungTu();
            hdct.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width != 55)
            {
                //  pnMenu.Width = 55;
                while (pnMenu.Width < 201)
                {
                    if (pnMenu.Width == 55)
                        break;
                    pnMenu.Width--;
                }
            }
            else
            {
                pnMenu.Width = 160;
                while (pnMenu.Width > 54)
                {
                    if (pnMenu.Width == 200)
                        break;
                    pnMenu.Width++;

                }
            }
        }

     
    }
       
}

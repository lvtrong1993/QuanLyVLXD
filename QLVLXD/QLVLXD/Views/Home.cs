using QLVLXD.Controllers;
using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVLXD.Views
{
    public partial class Home : Form
    {
        private static int x, y;
        private List<HANGHOA> hh = null;
        private List<string> listTenHH = null;
        HangHoaController hC = new HangHoaController();
        KhachHangController kC = new KhachHangController();
        HoaDonChungTuController hdctC = new HoaDonChungTuController();
        CTHDController cthdC = new CTHDController();
        KHACHHANG kh;
     
        private bool checkValidHH = false;
        private int maHH;
        private int tongTien=0;
        private int addHD; // số hóa đơn
        int thanhTien = 0;
        private int maKHMoi;
        public Home()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            cbChietKhau.SelectedIndex = 0;
            txtTongTien.Text = "";
            txtThanhTien.Text = "";
            txtMaKH.Enabled = false;
            txtSLTon.Enabled = false;
            LoadDataHH();
            this.dataGridView1.AllowUserToAddRows = false;
            cbHangHoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbHangHoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection dataCbHH = new AutoCompleteStringCollection();
               for (int i = 0; i < hh.Count; i++)
               {
                dataCbHH.Add(hh[i].TENHH+" - "+hh[i].MAHH);
                cbHangHoa.Items.Add(hh[i].TENHH + " - " + hh[i].MAHH);
            }
            
            cbHangHoa.AutoCompleteCustomSource = dataCbHH;

            

        }
        private void autoCompleteCbHangHoa()
        {
            cbHangHoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbHangHoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            for (int i = 0; i < hh.Count; i++)
            {
                data.Add(hh[i].TENHH);
               // cbHangHoa.Items.Add(
            }
            cbHangHoa.AutoCompleteCustomSource = data;
        }
        
        private void LoadDataHH()
        {
           
            hh = hC.listAllHangHoa();
        }

        private void radKhachCu_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            btnThemMoiKH.Visible = false;
        }

        private void radKhachMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            btnThemMoiKH.Visible = true;
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

        private void cbHangHoa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbHangHoa.SelectedItem.ToString()))
            {
                MessageBox.Show(cbHangHoa.SelectedItem.ToString(), "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cbHangHoa_TextUpdate(object sender, EventArgs e)
        {
           /* if (string.IsNullOrEmpty(cbHangHoa.SelectedItem.ToString()))
            {
                MessageBox.Show(cbHangHoa.SelectedItem.ToString(), "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }

        private void cbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbHangHoa.SelectedItem.ToString()))
            {
                MessageBox.Show("Sai thông tin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }else
            {
                string tmmHH = cbHangHoa.SelectedItem.ToString();
               
                
                try
                {
                    var rs = tmmHH.Substring(tmmHH.LastIndexOf('-') + 2);
                    int idHH = Int32.Parse(rs);
                    bool checkExistH = hC.checkExistHH(idHH);
                    if (checkExistH == false)
                    {
                        MessageBox.Show("Sai thông tin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        checkValidHH = true;
                        maHH = idHH;
                        HANGHOA hh = hC.getHHById(maHH);
                        if (hh != null)
                        {
                            //  MessageBox.Show("ok " + hh.MAHH.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSLTon.Text = hh.SOLUONGTON.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Sai thông tin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        // MessageBox.Show("ngon quẩy đê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Sai thông tin vui lòng kiểm tra lại" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            NhaCungCap nhc = new NhaCungCap();
            nhc.Show();
            int x = this.DesktopBounds.Left + (this.Width - nhc.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nhc.Height) / 2;
            nhc.SetDesktopLocation(x, y);
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ok "+hh.MAHH.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (cbHangHoa.SelectedIndex <0 || string.IsNullOrEmpty(txtSLTon.Text)|| string.IsNullOrEmpty(txtSoLuongBan.Text))
            {
                MessageBox.Show("Thiếu thông tin hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int slt = Int32.Parse(txtSLTon.Text);
            int slb= Int32.Parse(txtSoLuongBan.Text);
            if (slb>slt)
            {
                MessageBox.Show("Số lượng bán không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkValidHH)
            {
                // bool checkHHExistHH = bhC.checkExistHH(maHH);
                HANGHOA hh = hC.getHHById(maHH);
                if (hh != null)
                {
                    //MessageBox.Show("ok "+hh.MAHH.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    int tt = (int)hh.DONGIA * slb;
                    dataGridView1.Rows.Add(hh.MAHH, hh.TENHH, hh.DONVITINH, txtSoLuongBan.Text, hh.DONGIA,tt.ToString());

                    tongTien += tt;
                    if (chkChietKhau.Checked == false )
                    {
                      //  tongTien += tt;
                        thanhTien = tongTien;
                        txtTongTien.Text = tongTien.ToString();
                        txtThanhTien.Text = thanhTien.ToString();
                    }else
                    {
                        if (!string.IsNullOrEmpty(txtChietKhau.Text))
                        {
                          //  tongTien += tt;
                            txtTongTien.Text = tongTien.ToString();
                            if (cbChietKhau.SelectedIndex == 0)
                            {
                                string ck = txtChietKhau.Text;
                                int ckhau = Int32.Parse(ck);
                                thanhTien = tongTien - ckhau;
                                txtThanhTien.Text = thanhTien.ToString();
                            }
                            else
                            {
                                string sphantramCk = txtChietKhau.Text;
                                int phanTramCK = Int32.Parse(sphantramCk);
                                thanhTien = tongTien - ((tongTien * phanTramCK) / 100);
                                txtThanhTien.Text = thanhTien.ToString();
                            }
                        }else
                        {
                         //   tongTien += tt;
                            thanhTien = tongTien;
                            txtTongTien.Text = tongTien.ToString();
                            txtThanhTien.Text = thanhTien.ToString();
                        }
                    }



                }
                else
                {
                    MessageBox.Show("Sai thông tin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                checkValidHH = false;
            }
        }
         private void tinhChietKhau()
        {
            if (chkChietKhau.Checked == false)
            {
                //  tongTien += tt;
                thanhTien = tongTien;
                txtTongTien.Text = tongTien.ToString();
                txtThanhTien.Text = thanhTien.ToString();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtChietKhau.Text))
                {
                    //  tongTien += tt;
                    txtTongTien.Text = tongTien.ToString();
                    if (cbChietKhau.SelectedIndex == 0)
                    {
                        string ck = txtChietKhau.Text;
                        int ckhau = Int32.Parse(ck);
                        thanhTien = tongTien - ckhau;
                        txtThanhTien.Text = thanhTien.ToString();
                    }
                    else
                    {
                        string sphantramCk = txtChietKhau.Text;
                        int phanTramCK = Int32.Parse(sphantramCk);
                        thanhTien = tongTien -  ((tongTien * phanTramCK) / 100);
                        txtThanhTien.Text = thanhTien.ToString();
                    }
                }
                else
                {
                  //  tongTien += tt;
                    thanhTien = tongTien;
                    txtTongTien.Text = tongTien.ToString();
                    txtThanhTien.Text = thanhTien.ToString();
                }
            }
        }
        private void txtChietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*  if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
              {
                  e.Handled = true;
              }

              // only allow one decimal point
              if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
              {
                  e.Handled = true;
              }*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private bool banHang()
        {
            DateTime dateNow = DateTime.Now;
            if (radKhachCu.Checked==true)
            {
                if (string.IsNullOrEmpty(txtMaKH.Text) == false)
                {
                    string stmpMaKH = txtMaKH.Text;
                    int tmpMKH = Int32.Parse(stmpMaKH);
                  //  MessageBox.Show("thanhtien"+thanhTien+"-date:"+dateNow+"-makh:"+tmpMKH+"-nhan vien"+ Session.nhanvien.MANV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    addHD = hdctC.addHD(thanhTien, dateNow, tmpMKH, Session.nhanvien.MANV);
                }
               
            }
            else
            {

                
                //    MessageBox.Show("ko check "+ maKHMoi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                ///
                if (maKHMoi>0)
                    addHD = hdctC.addHD(thanhTien, dateNow, maKHMoi, Session.nhanvien.MANV);
            }
            // addHD = hdctC.addHD(thanhTien, dateNow, 2, Session.nhanvien.MANV);
            if (addHD < 1)
            {
                  MessageBox.Show("sai o day"+addHD+"- thành tiền:"+thanhTien+"-date: "+dateNow+"-makh: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
              //  MessageBox.Show("mahh - "+ dataGridView1.Rows[i].Cells[0].Value.ToString() +" so luong- " + dataGridView1.Rows[i].Cells[3].Value.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                int MaHH = (int)dataGridView1.Rows[i].Cells[0].Value;
                string ssl= dataGridView1.Rows[i].Cells[3].Value.ToString();
                int sl = Int32.Parse(ssl);
                //  CTHOADON ct = new CTHOADON(addHD, MaHH, sl);
                int addCTHD = cthdC.addCTHD(addHD, MaHH, sl);
                if (addCTHD < 1)
                    return false;
            }
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                //cập nhật số lượng hàng hóa
                int MaHH2 = (int)dataGridView1.Rows[i].Cells[0].Value;
                string ssl2 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                int sl2 = Int32.Parse(ssl2);
                bool updateSL = hC.updateSLHH(MaHH2, sl2);
                if (updateSL == false)
                    return false;
            }
            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////
      

            ////////////////////////////////////////////////////
            if ((dataGridView1.Rows.Count ) < 1)
            {
                MessageBox.Show("Đơn hàng trống, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radKhachMoi.Checked == true)
            {
                if(string.IsNullOrEmpty(txtTenKH.Text)==true)
                {
                    MessageBox.Show("Thiếu thông tin khách hàng, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
            }

            tinhChietKhau();
            bool bh = banHang();
            if (bh)
            {
                MessageBox.Show("Bán hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    PrintDialog _PrintDialog = new PrintDialog();
                    PrintDocument _PrintDocument = new PrintDocument();

                    _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                    _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt); //add an event handler that will do the printing
                    _PrintDocument.Print();
                    //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                    /*DialogResult result = _PrintDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        _PrintDocument.Print();
                    }*/
                    
                }
                catch (Exception)
                {

                }
                addHD = 0;

            }
            else
                MessageBox.Show("Bán hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void cbChietKhau_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemMoiKH_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenKH.Text)|| string.IsNullOrEmpty(txtSDT.Text)|| string.IsNullOrEmpty(txtDiaChi.Text))
            {
               MessageBox.Show("Thiếu thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                string tenkh = txtTenKH.Text;
                int sdt = Int32.Parse(txtSDT.Text);
                string dc = txtDiaChi.Text;
                int chkID = kC.addNewKH(1, tenkh, sdt, dc);
                if (chkID < 1)
                {
                    MessageBox.Show("Không thể thêm mới khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thêm mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    maKHMoi = chkID;
                }
            }
            // bool check = khController.addKH(makh, tenkh, sdt, diachi);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            //  DateTime tmpTimeN = DateTime.Now;
            string DateFormat = "d/MM/yyyy HH:mm:ss";
            string tmpTimeN = DateTime.Now.ToString(DateFormat);
            graphic.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Courier New", 18), new SolidBrush(Color.Black), startX + 250, startY);
            graphic.DrawString("Số: " + addHD, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Black), startX +510, startY + 7);

            //string top = "Ngày lập ".PadRight(24) + tmpTimeN.ToString();
            //graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);

            string top = "Khách hàng: " + txtTenKH.Text.PadRight(24);// + tmpTimeN.ToString();
            graphic.DrawString(top, new Font("Courier New", 17, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            graphic.DrawString("HÀNG HÓA:", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("ĐƠN VỊ TÍNH", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 200, startY + offset);
            graphic.DrawString("SỐ LƯỢNG", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 350, startY + offset);
            graphic.DrawString("ĐƠN GIÁ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 500, startY + offset);
            graphic.DrawString("THÀNH TIỀN", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 650, startY + offset);
            offset = offset + (int)FontHeight + 10;
            for (int i = 0; i< dataGridView1.Rows.Count ; i++)
            {
                string tenHangPrint = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string donViTinhPrint = dataGridView1.Rows[i].Cells[2].Value.ToString();
                string soLuongPrint = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string donGiaPrint = dataGridView1.Rows[i].Cells[4].Value.ToString();
                string thanhTienPrint = dataGridView1.Rows[i].Cells[5].Value.ToString();
                graphic.DrawString(tenHangPrint, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(donViTinhPrint, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(soLuongPrint, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 350, startY + offset);
                graphic.DrawString(donGiaPrint, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(thanhTienPrint, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 650, startY + offset);
                offset = offset + (int)FontHeight + 5;
            }
            offset = offset + (int)FontHeight + 5;
            graphic.DrawString("-------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
           



            offset = offset + (int)FontHeight + 10; //make the spacing consistent 
            string ngayLapPrint = "Ngày lập ";// + tmpTimeN.ToString()

          //  offset = offset + (int)FontHeight + 5; //make the spacing consistent              

            graphic.DrawString(ngayLapPrint, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Nhân viên lập", font, new SolidBrush(Color.Black), startX + 230, startY + offset);
            graphic.DrawString("Tổng tiền: "+ tongTien.ToString(), font, new SolidBrush(Color.Black), startX + 550, startY + offset);
            offset = offset + (int)FontHeight + 5;
            graphic.DrawString(tmpTimeN.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(Session.nhanvien.TENNV, font, new SolidBrush(Color.Black), startX + 230, startY + offset);

            string ck = "0";
            if (chkChietKhau.Checked == true)
            {
                if(cbChietKhau.SelectedIndex == 0)
                {
                    if(!string.IsNullOrEmpty(txtChietKhau.Text))
                        ck = txtChietKhau.Text;
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtChietKhau.Text))
                        ck = txtChietKhau.Text + "%";
                }
            }
            graphic.DrawString("Chiết khấu: "+ck, font, new SolidBrush(Color.Black), startX + 540, startY + offset);
            offset = offset + (int)FontHeight + 5;
            graphic.DrawString("Tổng thanh toán: " + thanhTien.ToString(), font, new SolidBrush(Color.Black), startX + 490, startY + offset);



            //  graphic.DrawString(" CẢM ƠN VÀ HẸN GẶP LẠI QUÝ KHÁCH!", font, new SolidBrush(Color.Black), startX, startY + offset);
            // graphic.DrawString("HI VỌNG BẠN SẼ GHÉ THĂM LẠI!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            if (radKhachCu.Checked == true)
            {
                // gọi hàm lây infor khách hàng by id
                if (!string.IsNullOrEmpty(txtMaKH.Text))
                {
                    int khSearch = Int32.Parse(txtMaKH.Text);
                    kh = kC.getKHById(khSearch);
                    if (kh != null)
                    {
                        txtTenKH.Text = kh.TENKH;
                        txtSDT.Text = kh.SDT.ToString();
                        txtDiaChi.Text = kh.DIACHI;
                    }else
                    {
                        MessageBox.Show("Không tìm thấy thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtSoLuongBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.Show();
            int x = this.DesktopBounds.Left + (this.Width - tk.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - tk.Height) / 2;
            tk.SetDesktopLocation(x,y);
            this.Close();
            /*
                  Form1 f1 = new Form1();
            f1.Show();
            int x=this.DesktopBounds.Left + (this.Width-f1.Width)/2;
            int y=this.DesktopBounds.Top + (this.Height-f1.Height)/2;
            f1.SetDesktopLocation(x, y);*/
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSearchHotel_Paint(object sender, PaintEventArgs e)
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
                int x = this.DesktopBounds.Left + (this.Width - lg.Width) / 2;
                int y = this.DesktopBounds.Top + (this.Height - lg.Height) / 2;
                lg.SetDesktopLocation(x, y);
                this.Close();
                /*
                 * HangHoa nh = new HangHoa();
            nh.Show();
            int x = this.DesktopBounds.Left + (this.Width - nh.Width) / 2;
            int y = this.DesktopBounds.Top + (this.Height - nh.Height) / 2;
            nh.SetDesktopLocation(x, y);
            this.Close();
                 */
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

        private void btnHome_Click(object sender, EventArgs e)
        {

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

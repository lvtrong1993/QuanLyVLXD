using QLVLXD.Controllers;
using QLVLXD.Models.Entities;
using QLVLXD.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVLXD
{
    public partial class Form1 : Form
    {
        NhanVienController nC = new NhanVienController();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(this,"Thiếu thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string pwd  = txtPassword.Text;
                string us = txtUsername.Text;
                NHANVIEN lg = nC.login(us, pwd);
                if (lg == null)
                {
                    MessageBox.Show(this,"Sai thông tin đăng nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Session.nhanvien = lg;
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
            }
        }

        private void lblClose_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thoát chương trình?.", "Title", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '*';
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            /////////////////

       
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
              //  e.SuppressKeyPress = true;
               // e.Handled = true;
            }
        

        //////////////////
    }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

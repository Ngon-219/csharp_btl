﻿using Do_An_Quan_ly_kho;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_Quan_ly_kho.Model;
namespace WinFormDemo
{
    public partial class Login : Form
    {
        private Dbcontext db = new Dbcontext();
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtUsername.Text);
            Console.WriteLine(txtPassword.Text);
            var users = db.NguoiDungs.FirstOrDefault(x => x.TenDangNhap == txtUsername.Text && x.MatKhau == txtPassword.Text);
            if (users != null )
            {
                frmMain dashboard = new frmMain();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}

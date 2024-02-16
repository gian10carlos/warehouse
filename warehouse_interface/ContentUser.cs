using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using DataLayer.DataVoucher;
using MySql.Data.MySqlClient;
using warehouse_interface.Components;
using warehouse_interface.Views;

namespace warehouse_interface
{
    public partial class ContentUser : Form
    {
        //VIEW
        private readonly VoucherScreen voucherScreen = new VoucherScreen();

       public ContentUser()
        {
            InitializeComponent();

            userControl(voucherScreen);
            this.KeyPreview = true;

            this.KeyDown += ContentUser_KeyDown;
        }

        private void userControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void buttonReceipt_Click(object sender, EventArgs e)
        {
            userControl(voucherScreen);
            Color color = Color.FromArgb(224, 224, 224);
            buttonSetting.BackColor = color;
            buttonReceipt.BackColor = Color.Lavender;
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(224, 224, 224);
            buttonReceipt.BackColor = color;
            buttonSetting.BackColor =   Color.Lavender;
        }

        private void ContentUser_Load(object sender, EventArgs e)
        {

        }

        private void ContentUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.B)
            {
                OpenMyForm();
            }
        }

        FormLogin formLogin;
        private void OpenMyForm()
        {
            if (formLogin == null || formLogin.IsDisposed)
            {
                formLogin = new FormLogin();
                formLogin.FormClosed += (s, args) => formLogin = null;
                formLogin.Show();
            }
            else
            {
                formLogin.BringToFront();
            }
        }
    }
}

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
using MySql.Data.MySqlClient;
using warehouse_interface.Components;
using warehouse_interface.Views;

namespace warehouse_interface
{
    public partial class ContentUser : Form
    {
        //COMPONENTS
        private readonly ComponentTable componentTable = new ComponentTable();
        private readonly ComponentComboBox componentComboBox = new ComponentComboBox();
        private readonly ComponentTextBox componentTextBox = new ComponentTextBox();

        //VIEW
        private readonly SettingScreen settingScreen = new SettingScreen();
        private readonly VoucherScreen voucherScreen = new VoucherScreen();

        //TABLE
        private DataTable dataTable;

       public ContentUser()
        {
            InitializeComponent();
            userControl(voucherScreen);

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
            userControl(settingScreen);
            Color color = Color.FromArgb(224, 224, 224);
            buttonReceipt.BackColor = color;
            buttonSetting.BackColor =   Color.Lavender;
        }

        private void ContentUser_Load(object sender, EventArgs e)
        {

        }
    }
}

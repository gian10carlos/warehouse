using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_interface.Components.Manager;

namespace warehouse_interface
{
    public partial class FormLogin : Form
    {
        private Login login = new Login();
        public FormLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            if(login.IsLoggedIn(textBoxUser.Text, textBoxPassword.Text))
            {
                FormManager formManager = new FormManager();

                formManager.FormClosed += (s, args) => {
                    this.Show();
                };

                this.Hide();
                formManager.Show();
            }else
            {
                MessageBox.Show("USUARIO o CONTRASEÑA inconrrecta, vuelve a intentar por favor 😁");
            }

        }
    }
}

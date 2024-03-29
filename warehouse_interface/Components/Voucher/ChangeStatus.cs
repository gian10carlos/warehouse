﻿using DataLayer.DataVoucher.Updated;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_interface.Views;

namespace warehouse_interface.Components.Voucher
{
    public class ChangeStatus
    {
        private General general = new General();
        private readonly UpdatedClass updatedClass = new UpdatedClass();
        private readonly ComponentTable componentTable = new ComponentTable();

        public void waiting(Label txtInfoScan, TextBox user, TextBox client, TextBox inspect, TextBox receipt, ComboBox payment, ComboBox status, ComboBox type, int val)
        {
            general.DisabledEnabled(user, client, inspect, receipt, payment, status, type, val);
            user.Focus();
            txtInfoScan.Text = "Registrar usuario, Muestre su codigo de barra frente al lector 👍";

        }

        public void process(Label txtInfoScan, string user,  TextBox user_,TextBox client, TextBox inspect, TextBox receipt, ComboBox payment, ComboBox status, ComboBox type, int val)
        {
            general.DisabledEnabled(user_, client, inspect, receipt, payment, status, type, val);
            inspect.Focus();
            txtInfoScan.Text = "Registrar inpector, Muestre su codigo de barra frente al lector👍";
        }

        public void finish(Label txtInfoScan, TextBox user, TextBox client, TextBox inspect, TextBox receipt, ComboBox payment, ComboBox status, ComboBox type, int val) 
        {
            general.DisabledEnabled(user, client, inspect, receipt, payment, status, type, val);
            txtInfoScan.Text = "";
        }

        public int checkUser(string user, string inspect , object status)
        {
            if (status.Equals("SIN INICIAR") && user.EndsWith("20A"))
            {
                return 0;
            }
            if(status.Equals("PROCESO") && user.EndsWith("20A") && inspect.EndsWith("20A"))
            {
                return 1;
            }
            if (status.Equals("FINALIZADO") && user.EndsWith("20A") && inspect.EndsWith("20A"))
            {
                return 2;
            }
            else return 3;
        }

        public void dialog(int n, int id_t,string user, string inspect, DataGridView dGVTasks, string[] ftdate, TextBox tbUser, TextBox tbInspect) 
        {
            if (n == 0)
            {
                updatedClass.waiting(1 , id_t, user, default);
                componentTable.ComponentLoadTable(dGVTasks, ftdate);
                tbUser.Text = "";
                tbInspect.Text = "";
            }
            if(n == 2)
            {
                updatedClass.waiting(2, id_t, default, inspect);
                componentTable.ComponentLoadTable(dGVTasks, ftdate);
                tbUser.Text = "";
                tbInspect.Text = "";
            }
            if(n == 3)
            {
                MessageBox.Show("ERROR, VALORES INCORRECTOS!", "🧐", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

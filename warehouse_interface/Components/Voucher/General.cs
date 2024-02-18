using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse_interface.Components.Voucher
{
    public class General
    {
        private Boolean active = false;
        public void Clear(
            TextBox user, TextBox client, 
            TextBox inspect, TextBox receipt,
            ComboBox payment, ComboBox status, 
            ComboBox type, DataGridView dGVtasks
            )
        {
            DisabledEnabled(user, client, inspect, receipt, payment, status, type, 3);

            user.Text = "";
            client.Text = "";
            inspect.Text = "";
            receipt.Text = "";
            status.SelectedIndex = 0;
            type.SelectedIndex = 0;
            payment.SelectedIndex = 0;
        }

        public void DisabledEnabled(
            TextBox user = null, TextBox client = null, 
            TextBox inspect = null, TextBox receipt = null, 
            ComboBox payment = null, ComboBox status = null, 
            ComboBox type = null, int val = 3
            )
        {
            active = false;

            if(val == 3) active = true;

            if (user != null)  user.Enabled = active;

            if (client != null) client.Enabled = active;

            if (inspect != null) inspect.Enabled = active;

            if (receipt != null) receipt.Enabled = active;

            if (payment != null) payment.Enabled = active;

            if (status != null) status.Enabled = active;

            if (type != null) type.Enabled = active;

            if(val == 0) user.Enabled = true;
            if(val == 1) inspect.Enabled = true;
        }
    }
}

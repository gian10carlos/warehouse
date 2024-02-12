using Mysqlx.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace warehouse_interface.Components
{
    public class ComponentComboBox
    {

        public void Reset(ComboBox type, ComboBox status)
        {
            type.Enabled = true;
            status.Enabled = true;

            status.SelectedIndex = 0;
            type.SelectedIndex = 0;
        }

        public void ComboBoxPayment(ComboBox payment)
        {
            payment.Items.Add("TODOS");
            payment.Items.Add("B001");
            payment.Items.Add("B002");
            payment.Items.Add("B003");
            payment.SelectedIndex = 2;
            payment.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void ComboBoxType(ComboBox type) 
        {
            type.Items.Add("BOLETA DE VENTA");
            type.Items.Add("FACTURA");
            type.SelectedIndex = 0;
            type.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void ComboBoxStatus(ComboBox status)
        {
            status.Items.Add("SIN INICIAR");
            status.Items.Add("PROCESO");
            status.Items.Add("FINALIZADO");
            status.SelectedIndex = 0;
            status.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

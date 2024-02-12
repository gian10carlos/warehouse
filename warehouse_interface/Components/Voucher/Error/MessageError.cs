using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse_interface.Components.Voucher.Error
{
    internal class MessageError
    {
        public void Message(object message) 
        {
            MessageBox.Show("Error conexion base de datos, verifique su conexion a la red","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
    }
}

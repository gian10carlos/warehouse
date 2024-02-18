using DataLayer;
using DataLayer.DataVoucher;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_interface.Components.Voucher.Error;

namespace warehouse_interface.Components
{
    public class ComponentTable
    {
        private readonly Data data = new Data();
        private DataTable dataTable;

        private MessageError messageError = new MessageError();

        public BindingSource ComponentLoadTable(DataGridView dGVTasks, string[] ftdate)
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                var result = data.getTable(ftdate);

                if (result is DataTable)
                {
                    dataTable = (DataTable)result;
                    bindingSource.DataSource = dataTable;
                    dGVTasks.ReadOnly = true;
                    dGVTasks.AllowUserToAddRows = false;
                    dGVTasks.DataSource = bindingSource;
                }
                else if (result is string)
                {
                    messageError.Message(result);
                }
                return bindingSource;
            }
            catch (Exception ex)
            {
                messageError.Message(ex);
                return null;
            }
        }
    }
}

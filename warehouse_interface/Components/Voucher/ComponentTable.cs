using DataLayer;
using DataLayer.DataVoucher;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse_interface.Components
{
    public class ComponentTable
    {
        private readonly Data data = new Data();
        private DataTable dataTable;
        private BindingSource bindingSource = new BindingSource();

        public BindingSource ComponentLoadTable(DataGridView dGVTasks)
        {
            dataTable = data.getTable();
            bindingSource.DataSource = dataTable;
            dGVTasks.ReadOnly = true;
            dGVTasks.AllowUserToAddRows = false;
            dGVTasks.DataSource = bindingSource;

            return bindingSource;
        }
    }
}

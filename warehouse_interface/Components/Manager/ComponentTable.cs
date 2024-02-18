using DataLayer.DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_interface.Components.Voucher.Error;

namespace warehouse_interface.Components.Manager
{
    internal class ComponentTable
    {
        private TableClass tableClass = new TableClass();
        public void componentLoadTableUser(DataGridView dataGVReportDay)
        {
            DataTable dataTable = tableClass.getUserCountAmount();
            DataRow newRow = dataTable.NewRow();

            dataTable.Rows.InsertAt(newRow, 0);
            dataGVReportDay.DataSource = dataTable;
        }

        public void componentLoadTableSeller(DataGridView dataGVSeller)
        {
            DataTable dataTable = tableClass.getSeller();
            DataRow newRow = dataTable.NewRow();

            dataTable.Rows.InsertAt(newRow, 0);

            dataGVSeller.DataSource = dataTable;

            if(dataGVSeller.Columns.Count > 0)
            {
                dataGVSeller.Columns[0].Visible = false;
            }

        }

        public void ComponentLoadTablePayment(DataGridView dataGVpayment)
        {
            DataTable dataTable = tableClass.getPayment();
            dataGVpayment.DataSource = dataTable;

            if (dataGVpayment.Columns.Count > 0)
            {
                dataGVpayment.Columns[0].Visible = false;
            }
        }

        public int ComponentLoadValMin()
        {
            int val = 0;
            return val  = tableClass.getValMin();
        }

        /*public BindingSource componentLoadTableSeller(DataGridView dataGVSeller)
        {
            var result = tableClass.getSeller();

            if (result is DataTable)
            {
                dataTable = (DataTable)result;
                bindingSource.DataSource = dataTable;
                dataGVSeller.ReadOnly = true;
                dataGVSeller.AllowUserToAddRows = false;
                dataGVSeller.DataSource = bindingSource;
            }
            else if (result is string)
            {
                messageError.Message(result);
            }

            return bindingSource;
        }*/
    }
}

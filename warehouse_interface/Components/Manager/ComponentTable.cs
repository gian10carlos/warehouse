using DataLayer.DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse_interface.Components.Manager
{
    internal class ComponentTable
    {


        private TableClass tableClass = new TableClass();
        public void componentLoadTableUser(DataGridView dataGVReportDay)
        {
            DataTable dataTable = tableClass.getUserCountAmount();
            dataGVReportDay.DataSource = dataTable;
        }

        public void componentLoadTableSeller(DataGridView dataGVSeller)
        {
            DataTable dataTable = tableClass.getSeller();
            dataGVSeller.DataSource = dataTable;
        }

        public void ComponentLoadTablePayment(DataGridView dataGVpayment)
        {
            DataTable dataTable = tableClass.getPayment();
            dataGVpayment.DataSource = dataTable;
        }
    }
}

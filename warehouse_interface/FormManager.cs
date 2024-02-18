using DataLayer.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using warehouse_interface.Components.Manager;
using warehouse_interface.Components.Voucher;

namespace warehouse_interface
{
    public partial class FormManager : Form
    {
        private ComponentTable componentTable = new ComponentTable();
        private OperationManager operationManager = new OperationManager();
        private StatusTable statusTable = new StatusTable();
        private BindingSource bindingSourceS = new BindingSource();

        public FormManager()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Size = new System.Drawing.Size(1370, 700);
            dataGVReportMonth.AllowUserToResizeRows = false;
            dataGVReportMonth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGVPayment.AllowUserToResizeRows = false;
            dataGVPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGVSeller.AllowUserToResizeRows = false;
            dataGVSeller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            loadScore();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        public void loadTable()
        {
            textBoxMinAmount.Text = componentTable.ComponentLoadValMin().ToString();
            componentTable.componentLoadTableUser(dataGVReportMonth);
            componentTable.componentLoadTableSeller(dataGVSeller);
            componentTable.ComponentLoadTablePayment(dataGVPayment);
        }

        private void updatedValueMin()
        {
            if (operationManager.updatedValueMin(int.Parse(textBoxMinAmount.Text)))
            {
                textBoxMinAmount.Text = "";
                MessageBox.Show("Valores actulizados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(!textBoxMinAmount.Text.Equals("")) updatedValueMin();
        }

        private void loadScore()
        {
            var result = operationManager.loadScoreQuantity();
            List<string> usersList = result.users;
            List<string> countsList = result.counts;

            if(usersList.Count >= 5)
            {
                lblQuantity1.Text = countsList[0];
                lblQuantity2.Text = countsList[1];
                lblQuantity3.Text = countsList[2];
                lblQuantity4.Text = countsList[3];
                lblQuantity5.Text = countsList[4];

                lblQuantityName1.Text = usersList[0];
                lblQuantityName2.Text = usersList[1];
                lblQuantityName3.Text = usersList[2];
                lblQuantityName4.Text = usersList[3];
                lblQuantityName5.Text = usersList[4];
            }
        }

        private object[] valClickRowViewS;

        private void dataGVSeller_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow rowClick = dataGVSeller.Rows[e.RowIndex];

                valClickRowViewS = new object[rowClick.Cells.Count];

                for (int i = 0; i < rowClick.Cells.Count; i++) valClickRowViewS[i] = rowClick.Cells[i].Value;
                statusTable.updatedStatusS(valClickRowViewS);
                loadTable();
            }
        }

        private object[] valClickRowViewP;
        private void dataGVPayment_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow rowClick = dataGVPayment.Rows[e.RowIndex];

                valClickRowViewP = new object[rowClick.Cells.Count];

                for (int i = 0; i < rowClick.Cells.Count; i++) valClickRowViewP[i] = rowClick.Cells[i].Value;
                statusTable.updatedStatusP(valClickRowViewP);
                loadTable();
            }
        }

        private void textBoxSN_TextChanged_1(object sender, EventArgs e)
        {
            bindingSourceS.EndEdit();
            bindingSourceS.Filter = $"NOMBRE_VEND LIKE '{textBoxSN.Text}%'";
        }
    }
}

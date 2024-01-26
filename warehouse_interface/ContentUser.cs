using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace warehouse_interface
{
    public partial class ContentUser : Form
    {
        private DataTable dataTable;
        private readonly ClassData classData =  new ClassData();
        public ContentUser()
        {
            InitializeComponent();

            LoadTable();
            List<string> receiptAll = classData.getReceiptAll();

            AutoCompleteStringCollection autoCompleteStringCollectionReceipt = new AutoCompleteStringCollection();

            autoCompleteStringCollectionReceipt.AddRange(receiptAll.ToArray());

            textBoxReceipt.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxReceipt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxReceipt.AutoCompleteCustomSource = autoCompleteStringCollectionReceipt;
        }

        private void LoadTable()
        {
            dataTable = classData.getTable("GIAN");
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.DataSource = dataTable;
            dataGridView.Columns[1].Visible = false;
        }

        private void ContentUser_Load(object sender, EventArgs e)
        {
            comboBoxType.Items.Add("BOLETA");
            comboBoxType.Items.Add("FACTURA");
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.SelectedIndex = 0;

            comboBoxStatus.Items.Add("SIN INICIAR");
            comboBoxStatus.Items.Add("PROCESO");
            comboBoxStatus.Items.Add("FINALIZADO");
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.SelectedIndex = 0;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
        }

       private void FilterReceipt()
        {
            string receipt = textBoxReceipt.Text;

            DataRow[] results = dataTable.Select($"NUMERO LIKE '%{receipt}%'");
            DataTable dataTableFilter = dataTable.Clone();
            foreach (DataRow row in results)
            {
                dataTableFilter.ImportRow(row);
            }

            dataGridView.DataSource = dataTableFilter;
        }

        private void FilterUser()
        {
            string user = textBoxUser.Text;

            DataRow[] results = dataTable.Select($"USUARIO LIKE '%{user}%'");
            DataTable dataTableFilter = dataTable.Clone();
            foreach (DataRow row in results)
            {
                dataTableFilter.ImportRow(row);
            }
            dataGridView.DataSource = dataTableFilter;
        }

        private void UpdateDataGridView()
        {
            DataTable updatedDataTable = classData.getTable("GIAN");
            dataGridView.DataSource = updatedDataTable;
        }

        private Boolean filterReceipt = false;
        private Boolean filterClient = false;
        private Boolean checkUser = false;
        private int taskRowId = 0;
        private string status = "";

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filterReceipt = true;
            filterClient = true;

            int row =  dataGridView.CurrentCell.RowIndex;
            
            string user = dataGridView[0, row].Value.ToString();
            taskRowId = int.Parse(dataGridView[1, row].Value.ToString());
            string client = dataGridView[2, row].Value.ToString();
            string receipt = dataGridView[3, row].Value.ToString();
            string type = dataGridView[4, row].Value.ToString();
            status = dataGridView[5, row].Value.ToString();

            textBoxUser.Text = user;
            textBoxClient.Text = client;
            textBoxReceipt.Text = receipt;
            comboBoxType.Text = type;
            comboBoxStatus.Text = status;

            textBoxClient.Enabled = false;
            textBoxReceipt.Enabled = false;
            comboBoxType.Enabled = false;

            if (status.Equals("SIN INICIAR") && user.Equals(""))
            {
                comboBoxStatus.Enabled = true;
                textBoxUser.Enabled = true;
                textBoxUser.Focus();
                filterClient = true;

                user = "";
                textBoxUser.Text = user;

                labelInfoScan.Text = "Muestre su codigo de barras en el lector";
                checkUser = true;
            }
            else if (status.Equals("FINALIZADO"))
            {
                textBoxUser.Enabled = false;
                comboBoxStatus.Enabled = false;
                buttonClear_Click(sender, e);
            }
        }

        private void CheckUser(string user, object sender, EventArgs e)
        {
            if (classData.UserSearch(user))
            {
                DialogResult = MessageBox.Show("¿DESEA INICIAR CON ESTA TAREA?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.No) textBoxUser.Text = "";
                else
                {
                    DialogResult = MessageBox.Show("DESEA INICIAR CON ESTA TAREA?", "", MessageBoxButtons.YesNo);
                    if(DialogResult == DialogResult.Yes)
                    {
                        classData.StartTasks(user, "PROCESO", taskRowId);
                        LoadTable();
                        buttonClear_Click(sender, e);
                    }
                    else textBoxUser.Text = "";
                }
            }
            else MessageBox.Show("USUARIO NO ENCONTRADO");
        }

        private void ContentUser_MouseClick(object sender, MouseEventArgs e)
        {
            buttonClear_Click(sender, e);
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newStatus = classData.getStatus(taskRowId);

            if(newStatus.Equals("FINALIZADO") && comboBoxStatus.Text.Equals("FINALIZADO"))
            {
                DialogResult answer = MessageBox.Show("¿DESEA MARCAR ESTA TAREA COMO FINALIZADO?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(answer == DialogResult.Yes)
                {
                    classData.UpdateStatusFinish(taskRowId);
                    UpdateDataGridView();
                }
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            LoadTable();
            textBoxClient.Enabled = true;
            textBoxReceipt.Enabled = true;
            comboBoxType.Enabled = true;
            comboBoxStatus.Enabled = true;
            textBoxUser.Enabled=true;

            textBoxClient.Text = "";
            textBoxReceipt.Text = "";
            labelInfoScan.Text = "";
            textBoxUser.Text = "";
        }

        private void textBoxReceipt_TextChanged(object sender, EventArgs e)
        {
            if (!filterReceipt) FilterReceipt();
        }

        private void textBoxReceipt_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxReceipt.Enabled == true) filterReceipt = false;
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            if (!filterClient) FilterUser();
            if( textBoxUser.Text.EndsWith("01") && checkUser && status.Equals("SIN INICIAR"))
            {
                CheckUser(textBoxUser.Text,  sender,  e);
            }
        }

        private void textBoxUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxUser.Enabled == true) filterClient = false;
        }
    }
}

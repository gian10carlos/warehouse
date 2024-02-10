﻿using System;
using System.Data;
using System.Windows.Forms;
using warehouse_interface.Components;
using warehouse_interface.Components.Voucher;

namespace warehouse_interface.Views
{
    public partial class VoucherScreen : UserControl
    {
        private DataTable dataTable = new DataTable();
        private ComponentComboBox componentComboBox = new ComponentComboBox();
        private ComponentTextBox componentTextBox = new ComponentTextBox();
        private ComponentTable ComponentTable = new ComponentTable();
        private ChangeStatus changeStatus = new ChangeStatus();
        private General general = new General();

        BindingSource bindingSource = new BindingSource();
        private Boolean filterActive = false;

        public VoucherScreen()
        {
            InitializeComponent();
        }

        private void VoucherScreen_Load(object sender, EventArgs e)
        {
            componentComboBox.ComboBoxPayment(comboBoxPayment);
            componentComboBox.ComboBoxType(comboBoxType);
            componentComboBox.ComboBoxStatus(comboBoxStatus);
            bindingSource =  ComponentTable.ComponentLoadTable(dGVTasks);

            if (dGVTasks.Columns.Count > 0 && dGVTasks.Rows.Count > 0)
            {
                dGVTasks.Columns[0].Visible = false;
            }
        }

        private object[] valClickRowView;

        private void dGVTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                filterActive = true;

                DataGridViewRow rowClick = dGVTasks.Rows[e.RowIndex];

                valClickRowView = new object[rowClick.Cells.Count];

                for (int i = 0; i < rowClick.Cells.Count; i++) valClickRowView[i] = rowClick.Cells[i].Value;

                switch (valClickRowView[7])
                {
                    case "SIN INICIAR" : changeStatus.waiting(labelInfoScan, textBoxUser, textBoxClient, textBoxReceipt, textBoxInspect, comboBoxPayment, comboBoxStatus, comboBoxType, 0); break;
                    case "PROCESO": changeStatus.process(labelInfoScan, textBoxUser.Text, textBoxUser, textBoxClient, textBoxInspect, textBoxReceipt, comboBoxPayment, comboBoxStatus, comboBoxType, 1); break;
                    case "FINALIZADO": changeStatus.finish(labelInfoScan, textBoxUser, textBoxClient, textBoxReceipt, textBoxInspect, comboBoxPayment, comboBoxStatus, comboBoxType, 2); break;
                }
                asignedValText();
            }
        }

        public void asignedValText()
        {
            textBoxUser.Text = valClickRowView[1].ToString();
            textBoxInspect.Text = valClickRowView[2].ToString();
            textBoxClient.Text = valClickRowView[3].ToString();
            textBoxReceipt.Text = valClickRowView[5].ToString();
            comboBoxType.Text = valClickRowView[6].ToString();
            comboBoxStatus.Text = valClickRowView[7].ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            filterActive = false;
            general.Clear(textBoxUser, textBoxClient, textBoxInspect, textBoxReceipt, comboBoxPayment ,comboBoxStatus,comboBoxType ,dGVTasks);
            bindingSource.RemoveFilter();
            VoucherScreen_Load(sender, e);
            labelInfoScan.Text = "";
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            if (!filterActive)
            {
                bindingSource.Filter = $"USUARIO LIKE '{textBoxUser.Text}%'";
            }
            else
            {
                switch (changeStatus.checkUser(textBoxUser.Text, textBoxInspect.Text, valClickRowView[7]))
                {
                    case 0: changeStatus.dialog(0, Convert.ToInt32(valClickRowView[0]), textBoxUser.Text, textBoxInspect.Text, dGVTasks); break;
                    case 1: changeStatus.dialog(1, Convert.ToInt32(valClickRowView[0]), textBoxUser.Text, textBoxInspect.Text, dGVTasks); break;
                }
            }
        }

        private void textBoxInspect_TextChanged(object sender, EventArgs e)
        {
            if (changeStatus.checkUser(textBoxUser.Text, textBoxInspect.Text, valClickRowView[7]) == 1)
            {
                changeStatus.dialog(2, Convert.ToInt32(valClickRowView[0]), textBoxUser.Text, textBoxInspect.Text, dGVTasks);//INSPECT VALIDATED WAITING - PROCESS
            }
        }

        private void textBoxReceipt_TextChanged(object sender, EventArgs e)
        {
            if (!filterActive) bindingSource.Filter = $"SERIE_NUM LIKE '{textBoxReceipt.Text}%'";
        }

        private void dateRegister_ValueChanged(object sender, EventArgs e)
        {
            if (!filterActive)
            {
                DateTime selectedTime = dateRegister.Value.Date;

                string formatteDate = selectedTime.ToString("dd/MM/yyyy");

                if (formatteDate.Length > 0 && formatteDate[0] == '0')
                {
                    formatteDate = formatteDate.Substring(1);
                }
                bindingSource.Filter = $"CONVERT(CONVERT(FECHA, 'System.DateTime'), 'System.String') LIKE '{formatteDate}%'";
            }
            else bindingSource.RemoveFilter();
        }
    }
}
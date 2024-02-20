namespace warehouse_interface.Views
{
    partial class VoucherScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelForm = new System.Windows.Forms.Panel();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.textBoxInspect = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReceipt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.dGVTasks = new System.Windows.Forms.DataGridView();
            this.labelInfoScan = new System.Windows.Forms.Label();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.Controls.Add(this.dateTimeTo);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.dateTimeFrom);
            this.panelForm.Controls.Add(this.textBoxInspect);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.comboBoxPayment);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.buttonClear);
            this.panelForm.Controls.Add(this.textBoxUser);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.comboBoxStatus);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.textBoxReceipt);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.textBoxClient);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.comboBoxType);
            this.panelForm.Location = new System.Drawing.Point(20, 29);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1266, 217);
            this.panelForm.TabIndex = 18;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.CustomFormat = "dd-MM-yyyy";
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(508, 167);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(177, 28);
            this.dateTimeTo.TabIndex = 21;
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha Registro:";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.CustomFormat = "dd-MM-yyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(261, 167);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(177, 28);
            this.dateTimeFrom.TabIndex = 19;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // textBoxInspect
            // 
            this.textBoxInspect.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInspect.Location = new System.Drawing.Point(727, 56);
            this.textBoxInspect.Name = "textBoxInspect";
            this.textBoxInspect.Size = new System.Drawing.Size(354, 30);
            this.textBoxInspect.TabIndex = 18;
            this.textBoxInspect.TextChanged += new System.EventHandler(this.textBoxInspect_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(575, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Verificado:";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Location = new System.Drawing.Point(1044, 14);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(149, 33);
            this.comboBoxPayment.TabIndex = 16;
            this.comboBoxPayment.Text = "B004";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(935, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Caja:";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(1112, 131);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Padding = new System.Windows.Forms.Padding(10);
            this.buttonClear.Size = new System.Drawing.Size(119, 55);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Limpiar";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(138, 10);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(378, 30);
            this.textBoxUser.TabIndex = 13;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuario:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(654, 9);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(196, 33);
            this.comboBoxStatus.TabIndex = 10;
            this.comboBoxStatus.Text = "PROCESO";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado:";
            // 
            // textBoxReceipt
            // 
            this.textBoxReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceipt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReceipt.Location = new System.Drawing.Point(669, 116);
            this.textBoxReceipt.Name = "textBoxReceipt";
            this.textBoxReceipt.Size = new System.Drawing.Size(313, 30);
            this.textBoxReceipt.TabIndex = 8;
            this.textBoxReceipt.TextChanged += new System.EventHandler(this.textBoxReceipt_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero:";
            // 
            // textBoxClient
            // 
            this.textBoxClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClient.Location = new System.Drawing.Point(138, 60);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(378, 30);
            this.textBoxClient.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(109, 109);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(297, 33);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.Text = "BOLETA";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // dGVTasks
            // 
            this.dGVTasks.AllowUserToAddRows = false;
            this.dGVTasks.AllowUserToDeleteRows = false;
            this.dGVTasks.AllowUserToResizeRows = false;
            this.dGVTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVTasks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGVTasks.Location = new System.Drawing.Point(20, 262);
            this.dGVTasks.Name = "dGVTasks";
            this.dGVTasks.ReadOnly = true;
            this.dGVTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGVTasks.RowHeadersVisible = false;
            this.dGVTasks.RowHeadersWidth = 51;
            this.dGVTasks.RowTemplate.Height = 24;
            this.dGVTasks.ShowCellErrors = false;
            this.dGVTasks.Size = new System.Drawing.Size(1222, 310);
            this.dGVTasks.TabIndex = 19;
            this.dGVTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVTasks_CellContentClick);
            // 
            // labelInfoScan
            // 
            this.labelInfoScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoScan.AutoSize = true;
            this.labelInfoScan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelInfoScan.Location = new System.Drawing.Point(368, 588);
            this.labelInfoScan.Name = "labelInfoScan";
            this.labelInfoScan.Size = new System.Drawing.Size(21, 21);
            this.labelInfoScan.TabIndex = 20;
            this.labelInfoScan.Text = "*";
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // VoucherScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelInfoScan);
            this.Controls.Add(this.dGVTasks);
            this.Controls.Add(this.panelForm);
            this.Name = "VoucherScreen";
            this.Size = new System.Drawing.Size(1289, 636);
            this.Load += new System.EventHandler(this.VoucherScreen_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TextBox textBoxInspect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReceipt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridView dGVTasks;
        private System.Windows.Forms.Label labelInfoScan;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
    }
}

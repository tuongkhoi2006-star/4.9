namespace WinFormsApp4._9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCsvToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBoxInputs = new GroupBox();
            tableLayoutPanelInputs = new TableLayoutPanel();
            labelId = new Label();
            textBoxId = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelDate = new Label();
            dateTimePicker = new DateTimePicker();
            labelDoctor = new Label();
            comboBoxDoctor = new ComboBox();
            labelReason = new Label();
            textBoxReason = new TextBox();
            labelStatus = new Label();
            comboBoxStatus = new ComboBox();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            groupBoxList = new GroupBox();
            tableLayoutPanelList = new TableLayoutPanel();
            flowLayoutPanelFilters = new FlowLayoutPanel();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            labelFilterDate = new Label();
            dateTimePickerFilter = new DateTimePicker();
            checkBoxFilterDate = new CheckBox();
            labelFilterStatus = new Label();
            comboBoxFilterStatus = new ComboBox();
            dataGridView = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelCount = new ToolStripStatusLabel();
            errorProvider = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxInputs.SuspendLayout();
            tableLayoutPanelInputs.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            groupBoxList.SuspendLayout();
            tableLayoutPanelList.SuspendLayout();
            flowLayoutPanelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCsvToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportCsvToolStripMenuItem
            // 
            exportCsvToolStripMenuItem.Name = "exportCsvToolStripMenuItem";
            exportCsvToolStripMenuItem.Size = new Size(174, 26);
            exportCsvToolStripMenuItem.Text = "Export CSV...";
            exportCsvToolStripMenuItem.Click += exportCsvToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(groupBoxInputs, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxList, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(900, 446);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxInputs
            // 
            groupBoxInputs.Controls.Add(tableLayoutPanelInputs);
            groupBoxInputs.Dock = DockStyle.Fill;
            groupBoxInputs.Location = new Point(3, 3);
            groupBoxInputs.Name = "groupBoxInputs";
            groupBoxInputs.Size = new Size(309, 440);
            groupBoxInputs.TabIndex = 0;
            groupBoxInputs.TabStop = false;
            groupBoxInputs.Text = "Appointment";
            // 
            // tableLayoutPanelInputs
            // 
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelInputs.Controls.Add(labelId, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxId, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelName, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxName, 1, 1);
            tableLayoutPanelInputs.Controls.Add(labelPhone, 0, 2);
            tableLayoutPanelInputs.Controls.Add(textBoxPhone, 1, 2);
            tableLayoutPanelInputs.Controls.Add(labelDate, 0, 3);
            tableLayoutPanelInputs.Controls.Add(dateTimePicker, 1, 3);
            tableLayoutPanelInputs.Controls.Add(labelDoctor, 0, 4);
            tableLayoutPanelInputs.Controls.Add(comboBoxDoctor, 1, 4);
            tableLayoutPanelInputs.Controls.Add(labelReason, 0, 5);
            tableLayoutPanelInputs.Controls.Add(textBoxReason, 1, 5);
            tableLayoutPanelInputs.Controls.Add(labelStatus, 0, 6);
            tableLayoutPanelInputs.Controls.Add(comboBoxStatus, 1, 6);
            tableLayoutPanelInputs.Controls.Add(flowLayoutPanelButtons, 1, 7);
            tableLayoutPanelInputs.Dock = DockStyle.Fill;
            tableLayoutPanelInputs.Location = new Point(3, 23);
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.Padding = new Padding(8);
            tableLayoutPanelInputs.RowCount = 8;
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelInputs.Size = new Size(303, 414);
            tableLayoutPanelInputs.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(11, 14);
            labelId.Margin = new Padding(3, 6, 3, 6);
            labelId.Name = "labelId";
            labelId.Size = new Size(92, 16);
            labelId.TabIndex = 0;
            labelId.Text = "Appointment";
            labelId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxId
            // 
            textBoxId.Dock = DockStyle.Fill;
            textBoxId.Location = new Point(111, 11);
            textBoxId.Margin = new Padding(3, 3, 10, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(174, 27);
            textBoxId.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(11, 42);
            labelName.Margin = new Padding(3, 6, 3, 6);
            labelName.Name = "labelName";
            labelName.Size = new Size(54, 16);
            labelName.TabIndex = 2;
            labelName.Text = "Patient";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Fill;
            textBoxName.Location = new Point(111, 39);
            textBoxName.Margin = new Padding(3, 3, 10, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(174, 27);
            textBoxName.TabIndex = 3;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(11, 70);
            labelPhone.Margin = new Padding(3, 6, 3, 6);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(50, 16);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone";
            labelPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Dock = DockStyle.Fill;
            textBoxPhone.Location = new Point(111, 67);
            textBoxPhone.Margin = new Padding(3, 3, 10, 3);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(174, 27);
            textBoxPhone.TabIndex = 5;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(11, 98);
            labelDate.Margin = new Padding(3, 6, 3, 6);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(80, 16);
            labelDate.TabIndex = 6;
            labelDate.Text = "Date/Time";
            labelDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker.Dock = DockStyle.Fill;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(111, 95);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(181, 27);
            dateTimePicker.TabIndex = 7;
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.Location = new Point(11, 126);
            labelDoctor.Margin = new Padding(3, 6, 3, 6);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(55, 16);
            labelDoctor.TabIndex = 8;
            labelDoctor.Text = "Doctor";
            labelDoctor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.Dock = DockStyle.Fill;
            comboBoxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctor.Location = new Point(111, 123);
            comboBoxDoctor.Margin = new Padding(3, 3, 10, 3);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(174, 28);
            comboBoxDoctor.TabIndex = 9;
            // 
            // labelReason
            // 
            labelReason.AutoSize = true;
            labelReason.Location = new Point(11, 154);
            labelReason.Margin = new Padding(3, 6, 3, 6);
            labelReason.Name = "labelReason";
            labelReason.Size = new Size(57, 18);
            labelReason.TabIndex = 10;
            labelReason.Text = "Reason";
            labelReason.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxReason
            // 
            textBoxReason.Dock = DockStyle.Fill;
            textBoxReason.Location = new Point(111, 151);
            textBoxReason.Margin = new Padding(3, 3, 10, 3);
            textBoxReason.Multiline = true;
            textBoxReason.Name = "textBoxReason";
            textBoxReason.Size = new Size(174, 24);
            textBoxReason.TabIndex = 11;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(11, 184);
            labelStatus.Margin = new Padding(3, 6, 3, 6);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 16);
            labelStatus.TabIndex = 12;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Dock = DockStyle.Fill;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Location = new Point(111, 181);
            comboBoxStatus.Margin = new Padding(3, 3, 10, 3);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(174, 28);
            comboBoxStatus.TabIndex = 13;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(buttonAdd);
            flowLayoutPanelButtons.Controls.Add(buttonUpdate);
            flowLayoutPanelButtons.Controls.Add(buttonDelete);
            flowLayoutPanelButtons.Controls.Add(buttonClear);
            flowLayoutPanelButtons.Dock = DockStyle.Left;
            flowLayoutPanelButtons.Location = new Point(111, 209);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(181, 194);
            flowLayoutPanelButtons.TabIndex = 14;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(70, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(79, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(70, 23);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(3, 32);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(70, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(79, 32);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(70, 23);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Clear";
            buttonClear.Click += buttonClear_Click;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(tableLayoutPanelList);
            groupBoxList.Dock = DockStyle.Fill;
            groupBoxList.Location = new Point(318, 3);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(579, 440);
            groupBoxList.TabIndex = 1;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Appointments";
            // 
            // tableLayoutPanelList
            // 
            tableLayoutPanelList.ColumnCount = 1;
            tableLayoutPanelList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelList.Controls.Add(flowLayoutPanelFilters, 0, 0);
            tableLayoutPanelList.Controls.Add(dataGridView, 0, 1);
            tableLayoutPanelList.Dock = DockStyle.Fill;
            tableLayoutPanelList.Location = new Point(3, 23);
            tableLayoutPanelList.Name = "tableLayoutPanelList";
            tableLayoutPanelList.RowCount = 2;
            tableLayoutPanelList.RowStyles.Add(new RowStyle());
            tableLayoutPanelList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelList.Size = new Size(573, 414);
            tableLayoutPanelList.TabIndex = 0;
            // 
            // flowLayoutPanelFilters
            // 
            flowLayoutPanelFilters.Controls.Add(labelSearch);
            flowLayoutPanelFilters.Controls.Add(textBoxSearch);
            flowLayoutPanelFilters.Controls.Add(labelFilterDate);
            flowLayoutPanelFilters.Controls.Add(dateTimePickerFilter);
            flowLayoutPanelFilters.Controls.Add(checkBoxFilterDate);
            flowLayoutPanelFilters.Controls.Add(labelFilterStatus);
            flowLayoutPanelFilters.Controls.Add(comboBoxFilterStatus);
            flowLayoutPanelFilters.Dock = DockStyle.Fill;
            flowLayoutPanelFilters.Location = new Point(3, 3);
            flowLayoutPanelFilters.Name = "flowLayoutPanelFilters";
            flowLayoutPanelFilters.Size = new Size(567, 100);
            flowLayoutPanelFilters.TabIndex = 0;
            flowLayoutPanelFilters.WrapContents = false;
            // 
            // labelSearch
            // 
            labelSearch.Location = new Point(3, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(100, 23);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Search:";
            labelSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(109, 6);
            textBoxSearch.Margin = new Padding(3, 6, 10, 6);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(200, 27);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelFilterDate
            // 
            labelFilterDate.Location = new Point(322, 0);
            labelFilterDate.Name = "labelFilterDate";
            labelFilterDate.Size = new Size(100, 23);
            labelFilterDate.TabIndex = 2;
            labelFilterDate.Text = "Filter Date:";
            // 
            // dateTimePickerFilter
            // 
            dateTimePickerFilter.Format = DateTimePickerFormat.Short;
            dateTimePickerFilter.Location = new Point(428, 6);
            dateTimePickerFilter.Margin = new Padding(3, 6, 3, 6);
            dateTimePickerFilter.Name = "dateTimePickerFilter";
            dateTimePickerFilter.Size = new Size(110, 27);
            dateTimePickerFilter.TabIndex = 3;
            // 
            // checkBoxFilterDate
            // 
            checkBoxFilterDate.Location = new Point(544, 3);
            checkBoxFilterDate.Name = "checkBoxFilterDate";
            checkBoxFilterDate.Size = new Size(104, 24);
            checkBoxFilterDate.TabIndex = 4;
            checkBoxFilterDate.Text = "Enable";
            checkBoxFilterDate.CheckedChanged += checkBoxFilterDate_CheckedChanged;
            // 
            // labelFilterStatus
            // 
            labelFilterStatus.Location = new Point(654, 0);
            labelFilterStatus.Name = "labelFilterStatus";
            labelFilterStatus.Size = new Size(100, 23);
            labelFilterStatus.TabIndex = 5;
            labelFilterStatus.Text = "Status:";
            // 
            // comboBoxFilterStatus
            // 
            comboBoxFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterStatus.Location = new Point(760, 3);
            comboBoxFilterStatus.Name = "comboBoxFilterStatus";
            comboBoxFilterStatus.Size = new Size(120, 28);
            comboBoxFilterStatus.TabIndex = 6;
            comboBoxFilterStatus.SelectedIndexChanged += comboBoxFilterStatus_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.BackgroundColor = SystemColors.ControlLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 109);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(567, 302);
            dataGridView.TabIndex = 1;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCount });
            statusStrip1.Location = new Point(0, 474);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 26);
            statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabelCount
            // 
            toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            toolStripStatusLabelCount.Size = new Size(113, 20);
            toolStripStatusLabelCount.Text = "0 appointments";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            ClientSize = new Size(900, 500);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Clinic Appointment Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxInputs.ResumeLayout(false);
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            groupBoxList.ResumeLayout(false);
            tableLayoutPanelList.ResumeLayout(false);
            flowLayoutPanelFilters.ResumeLayout(false);
            flowLayoutPanelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();

            // populate default doctors and statuses in runtime (Form1 ctor)
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCsvToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxInputs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFilters;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelFilterDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilter;
        private System.Windows.Forms.CheckBox checkBoxFilterDate;
        private System.Windows.Forms.Label labelFilterStatus;
        private System.Windows.Forms.ComboBox comboBoxFilterStatus;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.ErrorProvider errorProvider;

        #endregion
    }
}

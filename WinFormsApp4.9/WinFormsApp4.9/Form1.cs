using System.ComponentModel;
using System.Text.RegularExpressions;

namespace WinFormsApp4._9
{
    public partial class Form1 : Form
    {
        private BindingList<Appointment> masterList = new BindingList<Appointment>();
        private BindingList<Appointment> displayList = new BindingList<Appointment>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            InitializeRuntime();
        }

        private void InitializeRuntime()
        {
            // populate doctors and statuses
            comboBoxDoctor.Items.AddRange(new object[] { "Dr. Nguyen", "Dr. Tran", "Dr. Le", "Dr. Pham" });
            comboBoxStatus.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            comboBoxFilterStatus.Items.AddRange(new object[] { "All", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            comboBoxFilterStatus.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;

            // setup DataGridView columns
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 90 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PatientName", HeaderText = "Patient", Width = 160 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "Phone", Width = 110 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AppointmentDateTime", HeaderText = "Date/Time", Width = 140 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Doctor", HeaderText = "Doctor", Width = 120 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Reason", HeaderText = "Reason", Width = 180 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status", Width = 100 });

            bindingSource.DataSource = displayList;
            dataGridView.DataSource = bindingSource;

            // set initial date value
            dateTimePicker.Value = DateTime.Now.AddHours(1);
            dateTimePickerFilter.Value = DateTime.Now.Date;

            UpdateStatusCount();
        }

        private void UpdateStatusCount()
        {
            int count = displayList.Count;
            toolStripStatusLabelCount.Text = $"{count} appointment" + (count == 1 ? "" : "s");
        }

        private bool ValidateInputs(out Appointment appt)
        {
            appt = null;
            errorProvider.Clear();
            bool ok = true;

            string id = textBoxId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                errorProvider.SetError(textBoxId, "ID is required");
                ok = false;
            }

            string name = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                errorProvider.SetError(textBoxName, "Patient name is required");
                ok = false;
            }

            string phone = textBoxPhone.Text.Trim();
            if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, "^\\+?[0-9\\- ]{7,20}$"))
            {
                errorProvider.SetError(textBoxPhone, "Invalid phone number");
                ok = false;
            }

            DateTime when = dateTimePicker.Value;
            if (when < DateTime.Now)
            {
                errorProvider.SetError(dateTimePicker, "Appointment date/time cannot be in the past");
                ok = false;
            }

            string reason = textBoxReason.Text.Trim();
            if (string.IsNullOrEmpty(reason))
            {
                errorProvider.SetError(textBoxReason, "Reason is required");
                ok = false;
            }

            if (!ok) return false;

            appt = new Appointment
            {
                Id = id,
                PatientName = name,
                Phone = phone,
                AppointmentDateTime = when,
                Doctor = comboBoxDoctor.SelectedItem?.ToString() ?? string.Empty,
                Reason = reason,
                Status = comboBoxStatus.SelectedItem?.ToString() ?? string.Empty
            };

            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out Appointment appt)) return;

            if (masterList.Any(a => a.Id == appt.Id))
            {
                MessageBox.Show("Appointment ID must be unique.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            masterList.Add(appt);
            RefreshList();
            ClearInputs();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an appointment to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInputs(out Appointment appt)) return;

            var selected = dataGridView.SelectedRows[0].DataBoundItem as Appointment;
            if (selected == null) return;

            if (masterList.Any(a => a.Id == appt.Id && a != selected))
            {
                MessageBox.Show("Another appointment with same ID exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // confirmation
            if (MessageBox.Show("Update selected appointment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // apply changes
            selected.Id = appt.Id;
            selected.PatientName = appt.PatientName;
            selected.Phone = appt.Phone;
            selected.AppointmentDateTime = appt.AppointmentDateTime;
            selected.Doctor = appt.Doctor;
            selected.Reason = appt.Reason;
            selected.Status = appt.Status;

            RefreshList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an appointment to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = dataGridView.SelectedRows[0].DataBoundItem as Appointment;
            if (selected == null) return;

            if (MessageBox.Show("Delete selected appointment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            masterList.Remove(selected);
            RefreshList();
            ClearInputs();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            textBoxId.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now.AddHours(1);
            comboBoxDoctor.SelectedIndex = -1;
            textBoxReason.Text = string.Empty;
            comboBoxStatus.SelectedIndex = 0;
            errorProvider.Clear();
        }

        private void RefreshList()
        {
            IEnumerable<Appointment> query = masterList;

            // apply search filter
            string q = textBoxSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(a => (a.PatientName ?? string.Empty).ToLower().Contains(q) || (a.Phone ?? string.Empty).ToLower().Contains(q));
            }

            // date filter
            if (checkBoxFilterDate.Checked)
            {
                var d = dateTimePickerFilter.Value.Date;
                query = query.Where(a => a.AppointmentDateTime.Date == d);
            }

            // status filter
            if (comboBoxFilterStatus.SelectedIndex > 0)
            {
                string st = comboBoxFilterStatus.SelectedItem.ToString();
                query = query.Where(a => a.Status == st);
            }

            var list = new BindingList<Appointment>(query.OrderBy(a => a.AppointmentDateTime).ToList());
            displayList = list;
            bindingSource.DataSource = displayList;
            dataGridView.DataSource = bindingSource;

            UpdateStatusCount();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void checkBoxFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void comboBoxFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;

            var appt = dataGridView.SelectedRows[0].DataBoundItem as Appointment;
            if (appt == null) return;

            textBoxId.Text = appt.Id;
            textBoxName.Text = appt.PatientName;
            textBoxPhone.Text = appt.Phone;
            dateTimePicker.Value = appt.AppointmentDateTime;
            comboBoxDoctor.SelectedItem = appt.Doctor;
            textBoxReason.Text = appt.Reason;
            comboBoxStatus.SelectedItem = appt.Status;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // same as selection change; already loads
        }

        private void exportCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.FileName = "appointments.csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var sw = new System.IO.StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("Id,PatientName,Phone,DateTime,Doctor,Reason,Status");
                        foreach (var a in displayList)
                        {
                            var line = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\"",
                                a.Id, a.PatientName, a.Phone, a.AppointmentDateTime.ToString("yyyy-MM-dd HH:mm"), a.Doctor, a.Reason.Replace("\"", "\"\""), a.Status);
                            sw.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Export completed", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KpiAccelerator
{
    public partial class IncidentForm : Form
    {
        private MainForm _mainForm;

        private DataTable _data;

        public IncidentForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            _data = new DataTable();
            _data.Columns.Add("ID", typeof(Guid));
            _data.Columns.Add("StartDate", typeof(DateTime));
            _data.Columns.Add("EndDate", typeof(DateTime));
            _data.Columns.Add("Name", typeof(string));
            _data.Columns.Add("DeploymentID", typeof(Guid));
            _data.Columns.Add("DeploymentName", typeof(string));
            this.dataGridView1.DataSource = _data;


            foreach (var incident in _mainForm.KpiData.Incidents)
            {
                this._data.Rows.Add(incident.ID,
                    incident.StartDate,
                    incident.EndDate,
                    incident.Name,
                    incident.Deployment?.ID,
                    incident.Deployment?.Name);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.Date.AddDays(1);

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm";
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now.Date.AddDays(1);


            this.comboBox1.Items.Clear();            
            foreach (var deployment in _mainForm.KpiData.Deployments.OrderByDescending(d => d.DeploymentDate))
            {
                this.comboBox1.Items.Add(deployment);
            }
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            this._mainForm.KpiData.Incidents = new List<Incident>();
            Deployment deployment;
            Incident incident;
            foreach (DataRow row in _data.Rows)
            {
                
                if(row["DeploymentID"] != null)
                {
                    deployment = _mainForm.KpiData.Deployments.SingleOrDefault(d => d.ID == (Guid)row["DeploymentID"]);
                }
                else
                {
                    deployment = null;
                }

                incident = new Incident
                {
                    ID = (Guid)row["ID"],
                    StartDate = (DateTime)row["StartDate"],
                    EndDate = (DateTime)row["EndDate"],
                    Name = (string)row["Name"],
                    Deployment = deployment
                };
                this._mainForm.KpiData.Incidents.Add(incident);

                if(deployment != null)
                {
                    if (deployment.Incidents == null) deployment.Incidents = new List<Incident>();
                    deployment.Incidents.Add(incident);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var deployment = (Deployment)this.comboBox1.SelectedItem as Deployment;

            this._data.Rows.Add(Guid.NewGuid(),
                this.dateTimePicker1.Value,
                this.dateTimePicker2.Value,
                this.textBox1.Text,
                deployment?.ID,
                deployment?.Name
                );
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }
    }
}

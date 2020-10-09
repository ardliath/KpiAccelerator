using CsvHelper;
using KpiAccelerator.Data;
using KpiAccelerator.Import;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KpiAccelerator
{
    public partial class DeploymentForm : Form
    {
        private MainForm _mainForm;

        private DataTable _data;

        public DeploymentForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            _data = new DataTable();
            _data.Columns.Add("ID", typeof(Guid));
            _data.Columns.Add("Date", typeof(DateTime));
            _data.Columns.Add("Name", typeof(string));
            this.dataGridView1.DataSource = _data;


            foreach (var deployment in _mainForm.KpiData.Deployments)
            {
                this._data.Rows.Add(deployment.ID,
                    deployment.DeploymentDate,
                    deployment.Name);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.Date.AddDays(1);
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            this._mainForm.KpiData.Deployments = new List<Deployment>();
            foreach(DataRow row in _data.Rows)
            {
                this._mainForm.KpiData.Deployments.Add(new Deployment
                {
                    ID = (Guid)row["ID"],
                    DeploymentDate = (DateTime)row["Date"],
                    Name = (string)row["Name"],
                });
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this._data.Rows.Add(Guid.NewGuid(),
                this.dateTimePicker1.Value,
                this.textBox1.Text);

            this.textBox1.Text = null;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {                    
                    using (var reader = new StreamReader(open.FileName))
                    {
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var records = csv.GetRecords<DeploymentRow>().ToArray();

                            foreach(var record in records)
                            {
                                var date = DateTime.ParseExact(StripBrackets(record.ClosedDate), "ddd MMM dd yyyy HH:mm:ss 'GMT'K", CultureInfo.InvariantCulture);

                                bool doesExist = false;
                                foreach(DataRow row in _data.Rows)
                                {
                                    if(((DateTime)row["Date"]).Equals(date))
                                    {
                                        doesExist = true;
                                        break;
                                    }
                                }

                                if (!doesExist)
                                {

                                    this._data.Rows.Add(Guid.NewGuid(), date, record.Name);
                                }
                            }                            
                        }
                    }
                }
            }
        }


        public string StripBrackets(string value)
        {
            var indexOfFirstBracket = value.IndexOf('(');
            if (indexOfFirstBracket >= 0)
            {
                return value.Substring(0, indexOfFirstBracket - 1);
            }
            else
            {
                return value;
            }
        }
    }
}

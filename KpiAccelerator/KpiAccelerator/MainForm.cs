using CsvHelper;
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
    public partial class MainForm : Form
    {
        public KpiData KpiData { get; set; }


        public MainForm()
        {
            InitializeComponent();

            this.KpiData = new KpiData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.KpiData.WorkItems = new List<WorkItem>();
                    using (var reader = new StreamReader(open.FileName))
                    {
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var records = csv.GetRecords<WorkItemRow>().ToArray();

                            var newData = records.Select(w => new WorkItem
                                {
                                    ID = w.ID,
                                    State = w.State,
                                    Title = w.Title,
                                    LeadTime = null,
                                    CreatedDate = DateTime.ParseExact(StripBrackets(w.CreatedDate), "ddd MMM dd yyyy HH:mm:ss 'GMT'K", CultureInfo.InvariantCulture),
                                    ClosedDate = string.IsNullOrWhiteSpace(w.ClosedDate)
                                        ? (DateTime?)null
                                        : DateTime.ParseExact(StripBrackets(w.ClosedDate), "ddd MMM dd yyyy HH:mm:ss 'GMT'K", CultureInfo.InvariantCulture)
                                });


                            this.KpiData.WorkItems.AddRange(newData.Select(w => new WorkItem
                            {
                                ID = w.ID,
                                ClosedDate = w.ClosedDate,
                                CreatedDate = w.CreatedDate,
                                Title = w.Title,
                                State = w.State,
                                LeadTime = w.ClosedDate.HasValue
                                    ? w.ClosedDate.Value - w.CreatedDate
                                    : (TimeSpan?)null
                            }));
                            

                            this.KpiData.WorkItems.AddRange(newData);

                            this.RefreshKPIs();
                        }
                    }
                }
            }
        }

        private void RefreshKPIs()
        {
            this.LabelValueKpiLeadTime.Text = $"{Math.Round(this.KpiData.AverageLeadTime.TotalDays, 0)} days";
            this.LabelValueKpiDeployments.Text = $"{this.KpiData.NumberOfDeployments} in the last 3 months";
        }

        public string StripBrackets(string value)
        {
            var indexOfFirstBracket = value.IndexOf('(');
            if(indexOfFirstBracket >=0 )
            {
                return value.Substring(0, indexOfFirstBracket - 1);
            }
            else
            {
                return value;
            }
        }

        private void deploymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var deployments = new DeploymentForm(this))
            {
                if(deployments.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshKPIs();
                }
            }
        }

        private void incidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var deployments = new IncidentForm(this))
            {
                if (deployments.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshKPIs();
                }
            }
        }
    }
}

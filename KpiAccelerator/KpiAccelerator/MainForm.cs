﻿using CsvHelper;
using KpiAccelerator.Data;
using KpiAccelerator.Import;
using Newtonsoft.Json;
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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                var path = GetDataFileName();
                var data = File.ReadAllText(path);
                var deserialised = JsonConvert.DeserializeObject<KpiData>(data);
                this.KpiData = deserialised;
                foreach(var incident in this.KpiData.Incidents) // there's a circular reference in the JSON so this relationship is ignored, restore manually here
                {
                    if(incident.Deployment != null)
                    {
                        incident.Deployment.Incidents.Add(incident);
                    }
                }
                this.RefreshKPIs();
            }
            catch(Exception)
            {
                this.KpiData = null;
            }
            if(KpiData == null)
            {
                this.KpiData = new KpiData();
            }
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
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))                        {
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
            var calculator = new KpiCalculator(this.KpiData);

            var leadTime = calculator.CalculateAverageLeadTime();
            var deployments = calculator.CalculateNumberOfDeployments();
            var successful = calculator.CalculateSuccessfulChangePercentage();
            var recovery = calculator.CalculateAverageRecoveryTime();

            this.LabelValueKpiLeadTime.Text = $"{Math.Round(leadTime.TotalDays, 0)} days Average Lead Time";
            this.LabelValueKpiDeployments.Text = $"{deployments} deployments in the last 3 months";
            this.LabelValueKpiSuccessful.Text = $"{successful} % of changes in the last 3 months were successful";
            this.LabelValueKpiRecovery.Text = $"{Math.Round(recovery.TotalHours)} hours to recover from incidents";

            SaveKpiData();
        }

        private void SaveKpiData()
        {
            var path = GetDataFileName();
            var json = JsonConvert.SerializeObject(this.KpiData);
            File.WriteAllText(path, json);
        }

        protected string GetDataFileName()
        {
            return $"{AppDomain.CurrentDomain.BaseDirectory}\\KpiData.kpia";
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

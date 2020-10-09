using System;
using System.Collections.Generic;
using System.Linq;

namespace KpiAccelerator.Data
{
    public class KpiData
    {
        public List<WorkItem> WorkItems { get; set; }

        public List<Deployment> Deployments { get; set; }

        public List<Incident> Incidents { get; set; }

        public KpiData()
        {
            this.WorkItems = new List<WorkItem>();
            this.Deployments = new List<Deployment>();
            this.Incidents = new List<Incident>();
        }
    }
}
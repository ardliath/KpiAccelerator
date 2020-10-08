using System;
using System.Collections.Generic;

namespace KpiAccelerator
{
    public class Deployment
    {
        public Guid ID { get; set; }
        public DateTime DeploymentDate { get; set; }

        public string Name { get; set; }

        public List<Incident> Incidents { get; set; }

        public Deployment()
        {
            this.Incidents = new List<Incident>();
        }

        public override string ToString()
        {
            return $"{this.Name} - ({this.DeploymentDate.ToShortDateString()})";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool WasSucces
        {
            get
            {
                if (this.Incidents == null) return true;
                return !this.Incidents.Any();
            }
        }
    }
}
using System;

namespace KpiAccelerator
{
    public class Deployment
    {
        public Guid ID { get; set; }
        public DateTime DeploymentDate { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - ({this.DeploymentDate.ToShortDateString()})";
        }
    }
}
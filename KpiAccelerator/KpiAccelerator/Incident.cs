using System;

namespace KpiAccelerator
{
    public class Incident
    {
        public Guid ID { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Name { get; set; }

        public Deployment Deployment { get; set; }
    }
}
using Newtonsoft.Json;
using System;

namespace KpiAccelerator.Data
{
    public class Incident
    {
        public Guid ID { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Name { get; set; }

        public Deployment Deployment { get; set; }

        [JsonIgnore]
        public TimeSpan? RecoveryTime
        {
            get
            {
                return this.EndDate.Subtract(this.StartDate);
            }
        }
    }
}
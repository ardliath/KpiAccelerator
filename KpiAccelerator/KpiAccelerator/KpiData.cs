using System;
using System.Collections.Generic;
using System.Linq;

namespace KpiAccelerator
{
    public class KpiData
    {
        public List<WorkItem> WorkItems { get; set; }

        public KpiData()
        {
            this.WorkItems = new List<WorkItem>();
        }


        public TimeSpan AverageLeadTime
        {
            get
            {
                var averageTicks = (long)this.WorkItems
                    .Where(w => w.LeadTime.HasValue)
                    .OrderByDescending(w => w.ClosedDate)
                    .Take(10) // take the ten most recent WorkItems
                    .Select(w => w.LeadTime.Value.Ticks)
                    .Average();
                return new TimeSpan(averageTicks);
            }
        }
    }
}
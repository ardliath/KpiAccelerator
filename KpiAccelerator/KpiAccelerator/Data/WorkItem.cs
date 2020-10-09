using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpiAccelerator.Data
{
    public class WorkItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string State { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ClosedDate { get; set; }

        public TimeSpan? LeadTime { get; set; }
    }
}

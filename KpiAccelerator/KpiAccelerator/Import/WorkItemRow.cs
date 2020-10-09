using CsvHelper.Configuration.Attributes;
using System;

namespace KpiAccelerator.Import
{
    public class WorkItemRow
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string State { get; set; }

        [Name("Created Date")]
        public string CreatedDate { get; set; }

        [Name("Closed Date")]
        public string ClosedDate { get; set; }
    }
}
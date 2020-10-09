using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpiAccelerator.Import
{
    public class DeploymentRow
    {
        public int ID { get; set; }

        [Name("Title")]
        public string Name { get; set; }
        public string State { get; set; }

        [Name("Closed Date")]
        public string ClosedDate { get; set; }
    }
}

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


        public TimeSpan AverageLeadTime
        {
            get
            {
                if (this.WorkItems != null && this.WorkItems.Any())
                {
                    var averageTicks = (long)this.WorkItems
                        .Where(w => w.LeadTime.HasValue)
                        .OrderByDescending(w => w.ClosedDate)
                        .Take(10) // take the ten most recent WorkItems
                        .Select(w => w.LeadTime.Value.Ticks)
                        .Average();
                    return new TimeSpan(averageTicks);
                }
                return new TimeSpan();
            }
        }

        public int NumberOfDeployments
        {
            get
            {
                if(this.Deployments != null)
                {
                    return this.Deployments.Count(d => d.DeploymentDate >= DateTime.Now.AddMonths(-3));
                }

                return 0;
            }
        }


        public int SuccessfulChangePercentage
        {
            get
            {
                var allChanges = this.Deployments.Where(d => d.DeploymentDate >= DateTime.Now.AddMonths(-3));
                if (!allChanges.Any()) return 0;

                var successfulChanges = allChanges.Where(c => c.WasSucces);

                return (int)(100 * (double)(successfulChanges.Count() / (double)allChanges.Count()));
            }
        }

        public TimeSpan AverageRecoveryTime
        {
            get
            {
                if (this.Incidents == null || !this.Incidents.Any(w => w.RecoveryTime.HasValue)) return new TimeSpan();

                var averageTicks = (long)this.Incidents
                        .Where(w => w.RecoveryTime.HasValue)
                        .OrderByDescending(w => w.EndDate)
                        .Take(10) // take the ten most recent WorkItems
                        .Select(w => w.RecoveryTime.Value.Ticks)
                        .Average();

                return new TimeSpan(averageTicks);
            }
        }
    }
}
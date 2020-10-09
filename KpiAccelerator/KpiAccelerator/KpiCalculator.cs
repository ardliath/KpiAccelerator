using KpiAccelerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpiAccelerator
{
    public class KpiCalculator
    {
        private KpiData _data;

        public KpiCalculator(KpiData data)
        {
            _data = data;
        }


        public TimeSpan CalculateAverageLeadTime()
        {
            if (_data.WorkItems != null && _data.WorkItems.Any())
            {
                var averageTicks = (long)_data.WorkItems
                    .Where(w => w.LeadTime.HasValue)
                    .OrderByDescending(w => w.ClosedDate)
                    .Take(10) // take the ten most recent WorkItems
                    .Select(w => w.LeadTime.Value.Ticks)
                    .Average();
                return new TimeSpan(averageTicks);
            }
            return new TimeSpan();
        }

        public int CalculateNumberOfDeployments()
        {
            if (_data.Deployments != null)
            {
                return _data.Deployments.Count(d => d.DeploymentDate >= DateTime.Now.AddMonths(-3));
            }

            return 0;
        }


        public int CalculateSuccessfulChangePercentage()
        {
            var allChanges = _data.Deployments.Where(d => d.DeploymentDate >= DateTime.Now.AddMonths(-3));
            if (!allChanges.Any()) return 0;

            var successfulChanges = allChanges.Where(c => c.WasSucces);

            return (int)(100 * (double)(successfulChanges.Count() / (double)allChanges.Count()));
        }

        public TimeSpan CalculateAverageRecoveryTime()
        {
            if (_data.Incidents == null || !_data.Incidents.Any(w => w.RecoveryTime.HasValue)) return new TimeSpan();

            var averageTicks = (long)_data.Incidents
                    .Where(w => w.RecoveryTime.HasValue)
                    .OrderByDescending(w => w.EndDate)
                    .Take(10) // take the ten most recent WorkItems
                    .Select(w => w.RecoveryTime.Value.Ticks)
                    .Average();

            return new TimeSpan(averageTicks);
        }
    }
}

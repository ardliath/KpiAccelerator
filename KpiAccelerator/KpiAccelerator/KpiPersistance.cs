using KpiAccelerator.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpiAccelerator
{
    public class KpiPersistance
    {
        public static KpiData Load()
        {
            var path = GetDataFileName();
            var data = File.ReadAllText(path);
            var deserialised = JsonConvert.DeserializeObject<KpiData>(data);            
            foreach (var incident in deserialised.Incidents) // there's a circular reference in the JSON so this relationship is ignored, restore manually here
            {
                if (incident.Deployment != null)
                {
                    incident.Deployment.Incidents.Add(incident);
                }
            }

            return deserialised;
        }

        public static void Save(KpiData data)
        {
            var path = GetDataFileName();
            var json = JsonConvert.SerializeObject(data);
            File.WriteAllText(path, json);
        }

        protected static string GetDataFileName()
        {
            return $"{AppDomain.CurrentDomain.BaseDirectory}\\KpiData.kpia";
        }
    }
}

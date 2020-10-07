using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KpiAccelerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //var date = DateTime.ParseExact(
            //    "Mon Jan 13 2014 00:00:00 GMT+0000 (GMT Standard Time)",
            //    "ddd MMM dd yyyy HH:mm:ss 'GMT'K '(GMT Standard Time)'",
            //    CultureInfo.InvariantCulture);

            DateTime.ParseExact("Thu Jun 14 2018 10:32:15 GMT+0100 (British Summer Time)",
                "ddd MMM dd yyyy HH:mm:ss 'GMT'K '(British Summer Time)'",
                CultureInfo.InvariantCulture);

            using (var open = new OpenFileDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (var reader = new StreamReader(open.FileName))
                    {
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var records = csv.GetRecords<WorkItemRow>();

                            long averageTicks = (long)records.Where(w => !string.IsNullOrWhiteSpace(w.ClosedDate))
                                .Select(w => new
                                {
                                    CreatedDate = DateTime.ParseExact(StripBrackets(w.CreatedDate), "ddd MMM dd yyyy HH:mm:ss 'GMT'K", CultureInfo.InvariantCulture),
                                    ClosedDate = DateTime.ParseExact(StripBrackets(w.ClosedDate), "ddd MMM dd yyyy HH:mm:ss 'GMT'K", CultureInfo.InvariantCulture)
                                })
                                .Select(w => w.ClosedDate - w.CreatedDate)
                                .Select(ts => ts.Ticks)
                                .Average();

                            var averageLeadTime = new TimeSpan(averageTicks);


                        }
                    }
                }
            }
        }

        public string StripBrackets(string value)
        {
            var indexOfFirstBracket = value.IndexOf('(');
            if(indexOfFirstBracket >=0 )
            {
                return value.Substring(0, indexOfFirstBracket - 1);
            }
            else
            {
                return value;
            }
        }
    }
}

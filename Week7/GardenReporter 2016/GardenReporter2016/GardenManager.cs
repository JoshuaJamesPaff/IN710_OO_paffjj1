using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class GardenManager
    {
        //list of gardens
        private List<Garden> gardens;

        //delagte for processign garden data
        public delegate string ProcessDelegate(Garden garden);

        public GardenManager()
        {
            gardens = new List<Garden>();
        }

        public void AddGarden(Garden garden)
        {
            gardens.Add(garden);
        }
        
        //returns a list of strings to report
        public List<string> ProcessGardens(ProcessDelegate processDelegate)
        {
            List<string> gardenReports = new List<string>();
            foreach (Garden garden in gardens)
            {
                gardenReports.Add(processDelegate(garden));
            }

            return gardenReports;
        }

        //REPORT METHODS

        public string ReportArea(Garden garden)
        {
            String reportString = String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetArea());
            return reportString;
        }

        public string ReportCharges(Garden garden)
        {
            String reportString = String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, "$" + garden.GetAccountBalance());
            return reportString;
        }

        // PRINTS REPORT BASED ON DELEGATE

        public void PrintReports(ListBox listBox1, ProcessDelegate proccessDelegate)
        {
            foreach (string item in ProcessGardens(proccessDelegate))
            {
                listBox1.Items.Add(item);
            }
        }

    }
}

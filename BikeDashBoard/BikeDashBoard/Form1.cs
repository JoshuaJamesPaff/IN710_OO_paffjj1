using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeDashBoard
{
    public partial class Form1 : Form
    {
        private SubjectSpeedMonitor bikeMonitor;
        private ObserverRPMDisplay rpmDisplay;
        private ObserverVelocityDisplay velocityDisplay;
        private ObserverCalorieDisplay calorieDisplay;

        public Form1()
        {
            InitializeComponent();
            bikeMonitor = new SubjectSpeedMonitor();

            rpmDisplay = new ObserverRPMDisplay(bikeMonitor, labelCurrentRPM);
            velocityDisplay = new ObserverVelocityDisplay(bikeMonitor, labelCurrentVelocity);
            calorieDisplay = new ObserverCalorieDisplay(bikeMonitor, labelCurrentCalories);
        }

        private void buttonSetRPM_Click(object sender, EventArgs e)
        {
            string input = textBoxRPMInput.Text;
            if (input.Equals(""))
            {
                input = "0";
            }
            int currentSpeed = Int32.Parse(input);
            bikeMonitor.NotifyObservers(currentSpeed);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPC
{
    public abstract class PC
    {
        protected List<Component> parts = new List<Component>();
        protected IPCBuilder pcBuilder;
        protected ListBox displayBox;

        public PC(ListBox displayBox)
        {
            this.displayBox = displayBox;
        }

        public void BuildPC()
        {
            parts = pcBuilder.setComponents();
        }

        public void ShowSpecs()
        {
            displayBox.Items.Clear();

            int totalCost = 0;

            displayBox.Items.Add("Price" + "\t" + "Component");
            displayBox.Items.Add("----------------------------------------------------------");
            foreach (Component part in parts)
            {
                //displays each parts to string
                displayBox.Items.Add(part.ToString());
                totalCost += part.getPrice();
            }
            displayBox.Items.Add("----------------------------------------------------------");
            displayBox.Items.Add("Total: " + totalCost);
            
        }


    }
}

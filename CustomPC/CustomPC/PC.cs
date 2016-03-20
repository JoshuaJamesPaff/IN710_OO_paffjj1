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
        //has a list of components a component builder and a listbox to output to
        protected List<Component> parts = new List<Component>();
        protected IPCBuilder pcBuilder;
        protected ListBox displayBox;

        public PC(ListBox displayBox)
        {
            this.displayBox = displayBox;
        }

        //sets components
        public void BuildPC()
        {
            parts = pcBuilder.setComponents();
        }

        //outputs pc info
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

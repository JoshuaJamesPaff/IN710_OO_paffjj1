using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPC
{
    public class BusinessPC : PC
    {
        public BusinessPC(ListBox displayBox)
            :base(displayBox)
        {
            pcBuilder = new BusinessPCBuilder();
        }
    }
}

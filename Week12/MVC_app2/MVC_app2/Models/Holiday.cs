using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MVC_app2
{
    public class Holiday
    {
        public String name {set; get;}
        public DateTime date { set; get; }
        public String imageLoc { set; get; }

        public Holiday(String name, DateTime date, String imageLoc)
        {
            this.name = name;
            this.date = date;
            this.imageLoc = imageLoc;
        }
    }
}
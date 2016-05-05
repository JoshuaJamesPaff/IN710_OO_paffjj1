using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Queen : Character
    {
        public Queen(String name, ListBox display)
            : base(name, display)
        {
            this.name = name;
            this.display = display;
            weapon = new BowWeapon();
        }
        //declares as a queen
        public override void Declare(){
            display.Items.Add("My name is " + name);
            display.Items.Add("I am the powerful Queen");
            display.Items.Add(weapon.UseWeapon());
        }

        public override void ChangeWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }
    }
}

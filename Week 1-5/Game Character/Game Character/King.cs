using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class King : Character
    {
        public King(String name, ListBox display)
            : base(name, display)
        {
            this.name = name;
            this.display = display;
            weapon = new SwordWeapon();
        }
        //declares as a king
        public override void Declare(){
            display.Items.Add("My name is " + name);
            display.Items.Add("I am the most might of Kings");
            display.Items.Add(weapon.UseWeapon());
        }

        public override void ChangeWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }
    }
}

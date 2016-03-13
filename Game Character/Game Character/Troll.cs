using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Troll : Character
    {
        public Troll(String name, ListBox display)
            : base(name, display)
        {
            this.name = name;
            this.display = display;
            weapon = new BowWeapon();
        }
        //declares as a troll
        public override void Declare(){
            display.Items.Add("My name is " + name);
            display.Items.Add("Trolls don't have time to chat");
            display.Items.Add(weapon.UseWeapon());
        }

        public override void ChangeWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }
    }
}

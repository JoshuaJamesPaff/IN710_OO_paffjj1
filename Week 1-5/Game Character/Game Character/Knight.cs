using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Knight : Character
    {
        public Knight(String name, ListBox display)
            : base(name, display)
        {
            this.name = name;
            this.display = display;

            //default weapon
            weapon = new KnifeWeapon();
        }
        // declares as a knight 
        public override void Declare(){
            display.Items.Add("My name is " + name);
            display.Items.Add("I am a chivalrous knight");
            display.Items.Add(weapon.UseWeapon());
        }

        public override void ChangeWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }
    }
}

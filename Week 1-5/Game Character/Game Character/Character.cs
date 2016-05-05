using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public abstract class Character
    {
        //has a name, weapon and list box to print to
        protected String name;
        protected ListBox display;
        protected IWeapon weapon;

        public Character(String name, ListBox display){
            this.name = name;
            this.display = display;
        }

        //requires methods to declare and to change weapons
        public abstract void Declare();
        public abstract void ChangeWeapon(IWeapon weapon);

        public override string ToString()
        {
            return name;
        }
        
        
    }
}

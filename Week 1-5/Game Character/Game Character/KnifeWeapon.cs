﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class KnifeWeapon : IWeapon
    {
        public string UseWeapon()
        {
            return "I stab with my knife";
        }
    }
}

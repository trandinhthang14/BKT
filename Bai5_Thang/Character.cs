using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Thang
{
    internal class Character
    {
        public int Blood { get; set; }
        public int Mana { get; set; }
        public object Equipment { get; set; }

        public Character(int blood, int mana, object equipment)
        {
            Blood = blood;
            Mana = mana;
            Equipment = equipment;
        }

        public void Hit()
        {
            if (Equipment is IWeapon weapon)
            {
                weapon.Attack();
            }
            
        }
        public void Save()
        {
            if (Equipment is IItem item)
            {
                item.Defend();
            }
            
        }
    }
}

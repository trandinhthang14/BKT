using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Thang
{
    internal interface IWeapon
    {
        void Attack(ref int blood, ref int mana);
        void UpgradeWeapon();
    }
}

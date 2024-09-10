using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Thang
{
    internal interface IItem
    {
        void Defend(ref int damageBlood, ref int damageMana);
        void UpgradeItem();
    }
}

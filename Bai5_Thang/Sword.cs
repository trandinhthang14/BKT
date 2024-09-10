using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Thang
{
    internal class Sword : IWeapon
    {
        public int Kill { get; set; }
        public int DamageBlood { get; set; }
        public int DamageMana { get; set; }
        public Sword(int damageBlood, int damageMana)
        {
            Kill = 0; 
            DamageBlood = damageBlood;
            DamageMana = damageMana;
        }

        public void Attack(ref int blood, ref int mana)
        {
            blood -= DamageBlood;
            mana -= DamageMana;
            Console.WriteLine($"Attack: Giảm {DamageBlood} máu và {DamageMana} mana của đối phương.");
        }

      
        public void UpgradeWeapon()
        {
            if (Kill >= 5)
            {
                DamageBlood += 10;
                DamageMana += 5;
                Console.WriteLine("Vũ khí đã được nâng cấp.");
            }
        }
    }
}

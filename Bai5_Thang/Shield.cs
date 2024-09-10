using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Thang
{
    internal class Shield : IWeapon, IItem
    {
        public int Kill { get; set; }
        public int Count { get; set; }
        public int DamageBlood { get; set; }
        public int DamageMana { get; set; }
        public int ResitBlood { get; set; }
        public int ResitMana { get; set; }

        public Shield(int damageBlood, int damageMana, int resitBlood, int resitMana)
        {
            Kill = 0;
            Count = 0;
            DamageBlood = damageBlood;
            DamageMana = damageMana;
            ResitBlood = resitBlood;
            ResitMana = resitMana;
        }

       
        public void Attack(ref int blood, ref int mana)
        {
            blood -= DamageBlood;
            mana -= DamageMana;
            Console.WriteLine($"Shield Attack: Giảm {DamageBlood} máu và {DamageMana} mana của đối phương.");
        }

      
        public void Defend(ref int damageBlood, ref int damageMana)
        {
            damageBlood -= ResitBlood;
            damageMana -= ResitMana;
            Console.WriteLine($"Shield Defend: Giảm {ResitBlood} sát thương máu và {ResitMana} sát thương mana.");
        }

     
        public void UpgradeWeapon()
        {
            if (Kill >= 5)
            {
                DamageBlood += 10;
                DamageMana += 5;
                Console.WriteLine("Khiên đã được nâng cấp khả năng tấn công.");
            }
        }

       
        public void UpgradeItem()
        {
            if (Count >= 5)
            {
                ResitBlood += 10;
                ResitMana += 5;
                Console.WriteLine("Khiên đã được nâng cấp khả năng bảo vệ.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Thang
{
    internal class Armor : IItem
    {
        public int Count { get; set; }
        public int ResitBlood { get; set; }
        public int ResitMana { get; set; }

        public Armor(int resitBlood, int resitMana)
        {
            Count = 0;  
            ResitBlood = resitBlood;
            ResitMana = resitMana;
        }

        
        public void Defend(ref int damageBlood, ref int damageMana)
        {
            damageBlood -= ResitBlood;
            damageMana -= ResitMana;
            Console.WriteLine($"Defend: Giảm {ResitBlood} sát thương máu và {ResitMana} sát thương mana.");
        }

    
        public void UpgradeItem()
        {
            if (Count >= 5)
            {
                ResitBlood += 10;
                ResitMana += 5;
                Console.WriteLine("Áo giáp đã được nâng cấp.");
            }
        }
    }
}

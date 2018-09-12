using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Shop : IShopKeep 
    {
        public Shop(List<Armor> armorStock, List<Weapon> weaponStock, List<Potion> potionStock)
        {
            this.WeaponStock = weaponStock;
            this.ArmorStock = armorStock;
            this.PotionStock = potionStock;
        } 
         public List<Armor> ArmorStock { get; set; }
        
         public List<Weapon> WeaponStock { get; set; }
        
         public List<Potion> PotionStock { get; set; }  
    }

    public interface IShopKeep
    {
         List<Armor> ArmorStock { get; set; }
         List<Weapon> WeaponStock { get; set; }
         List<Potion> PotionStock { get; set; }
    }
}

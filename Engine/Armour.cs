using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  
    public class PlateArmour :Item
    {
        public PlateArmour() : base(40,(-5),10)
        {
           
        }

        public override ItemCategory GetItemCategory()
        {
            return ItemCategory.ARMOUR;
        }


        public override string EntityName()
        {
            return "Plate Armour";
        }

    }

    public class LeatherArmour: Item
    {
        public LeatherArmour() :base (20,0,5)
        {
          

        }

        public override string EntityName()
        {
            return "Leather Armour";
        }

        public override ItemCategory GetItemCategory()
        {
            return ItemCategory.ARMOUR;
        }


    }


  

}

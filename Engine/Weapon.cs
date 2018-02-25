using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

  

  public class Sword:Item
    {
      public Sword():base(10,10,0)
        {
            _ItemWeight = 10;
            _ItemAttack = 10;
        }

        public override ItemCategory GetItemCategory()
        {
            return ItemCategory.WEAPON;
        }

        public override string EntityName()
        {
            return "Sword";
        }
    }
  
    public class Dagger:Item
    {
        public Dagger():base(5,5,0)
        {
         

        }

        public override string EntityName()
        {
            return "Dagger";
        }

        public override ItemCategory GetItemCategory()
        {
            return ItemCategory.WEAPON;
        }

    }
}

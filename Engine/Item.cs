using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
     public abstract class Item:IEntity
    {
  
        public int _ItemWeight { get; set; } = 0;
        public int _ItemAttack { get; set; } = 0;
        public int _ItemDefence { get; } = 0;
      

        public Item(int weight, int attack , int defence)
        {
            _ItemWeight = weight;
            _ItemDefence = defence;
            _ItemAttack = attack;
        }

        public abstract ItemCategory GetItemCategory();
        public abstract string EntityName();
      

    }
}

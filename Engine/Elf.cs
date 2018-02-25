using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Elf :Character
    { 
        public Elf() :base(40, new int[] { 1, 1 }, 10, new int[] { 1, 4 }, 40,70)
        {

        }
       
        public override string SpecialRaceAbility()
        {
            _health++;
            return "Health Increased by 1";
        }

        public override string EntityName()
        {
            return "Elf";
        }


    }
}

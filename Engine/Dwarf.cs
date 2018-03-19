using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Dwarf: Character
    {

        public Dwarf() :base(30, new int[] { 2, 3 }, 20, new int[] { 2, 3 },50,130)
        {

        }

    
        public override string EntityName()
        {
            return "Dwarf";
        }

        public override string SpecialRaceAbility()
        {
            return "No Damage was done";
        }
    }
}

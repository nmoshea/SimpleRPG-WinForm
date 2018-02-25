using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Human:Character
    {
        public Human() : base(30, new int[] { 2, 3 }, 20, new int[] { 1, 2 }, 60, 100)
        {
         
        }

    public override string SpecialRaceAbility()
        {

            return "No Damage Caused ";

        }

        public override string EntityName()
        {
            return "Human";
        }

    }
}


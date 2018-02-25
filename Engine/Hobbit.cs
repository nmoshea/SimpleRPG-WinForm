using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Hobbit: Character
    {
        static Random rnd = new Random();
        public Hobbit() :base(25, new int[] { 1, 3 }, 20, new int[] { 2, 3 },70,85)
        {

        }

        public override string EntityName()
        {
            return "Hobbit";
        }

        public override string SpecialRaceAbility()
        {
            int damage = 0;
            damage= rnd.Next(0, 5);

            _health -= damage;

            if (damage == 0)
                return "No Damage was done";
            else
                return "health decreased by " + damage.ToString();
           

        }


    }
}

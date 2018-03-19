using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Orc:Character
    {

        public Orc() : base(25, new int[] { 1, 4 }, 10, new int[] { 1, 4 }, 50, 130)
        {
            
        }

        public override void PerformTimeMod()
        {
           if(Map.CurrentTime==DayOrNight.NIGHT)
            {
                _attack = 45;
                _defence = 25;
                _attackChance = 1;
                _defenceChance = (double)1/2;
            }

           else if (Map.CurrentTime == DayOrNight.DAY)
            {
                _attack = 25;
                _defence = 10;
                _attackChance = (double)1/4;
                _defenceChance = (double)1/4;
            }

        }

        public override string SpecialRaceAbility()
        {
            if (Map.CurrentTime == DayOrNight.NIGHT)
            {
                _health++;
                return "Health incresed by one";
            }

            else             
                return "No Damage Done";
            

        }

        public override string EntityName()
        {
            return "Orc";
        }

    }
}

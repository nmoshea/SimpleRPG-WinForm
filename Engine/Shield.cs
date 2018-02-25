using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   

        public class LargeShield :Item
        {
            public LargeShield(): base(30,(-5),10)
            {

            }

            public override ItemCategory GetItemCategory()
            {
                return ItemCategory.SHIELD;
            }


            public override string EntityName()
            {
                return "Large Shield";
            }
        }


        public class SmallShield : Item
        {
            public SmallShield() : base(10,0,5)
            {

            }

            public override ItemCategory GetItemCategory()
            {
                return ItemCategory.SHIELD;
            }


            public override string EntityName()
            {
                return "Small Shield";
            }
        }

    }


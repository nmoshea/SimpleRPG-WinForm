using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Location
    {
        public int _x { get; set; }
        public int _y { get; set; }

        public Location( int x,int y)
        {
            _x = x;
            _y = y;

        }

       public Location(Location other)
        {
            _x= other._x;
            _y= other._y;
        }



    }
}

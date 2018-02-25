using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

// the player will always be a human.
  public class Player:Human
    {
       

        public Location _point { get; set; }  //
        public Player(Location point, Inventory inventory)
        {
            _point = point;
            _charInventory = inventory;
        }

        public string MoveTo(Enum direction)
        {

            Location temp = new Location(_point);       //copy contstructor, creates a temp object  
            switch(direction)
            {
                case Map.Direction.north:
                    temp._y++;
                    break;
                case Map.Direction.south:
                    temp._y--;
                    break;
                case Map.Direction.east:
                    temp._x++;
                    break;
                case Map.Direction.west:
                    temp._x--;
                    break;

                    //add default case
            }
           
            if (Map.OnMap(temp))
                _point = temp;

            return "X= " + _point._x + ", Y= " + _point._y;
        }


    


    }
}

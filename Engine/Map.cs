using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine
{
  static public class Map
    {
      const int _ROW=10;
      const int _COLUMN =10;
      static private Location _PlayerLocation;
      static Random rnd = new Random();
      public static DayOrNight CurrentTime = DayOrNight.DAY;

      public enum Direction {
            north,
            south,
            east,
            west
        };

 static public IEntity[,] World;        
        


  public static void SetMap()
        {
             World= new IEntity[_COLUMN, _ROW]; 
            
     
        }

  public static bool OnMap(Location point)
        {
            
            bool inBound = (point._x < _ROW && point._x >= 0) && (point._y < _COLUMN && point._y >= 0);
           
            return  inBound;
         
        }

        public static void PopulateMap()
        {

            for (int j = 0; j < _COLUMN; j++)
            {
                for (int i = 0; i < _ROW; i++)
                {

                    int r = rnd.Next(0, 100);
                 
                    switch(r)
                    {
                        case 0:
                            World[j, i] = new Sword();
                            break;

                        case 1:
                            World[j, i] = new Dagger();
                            break;

                        case 2:
                            World[j, i] = new PlateArmour();
                            break;

                        case 3:
                            World[j, i] = new LeatherArmour();
                            break;

                        case 4:
                            World[j, i] = new LargeShield();
                            break;

                        case 5:
                            World[j, i] = new SmallShield();
                            break;
                        case 6:
                             World[j, i] = new LargeShield();
                            break;

                        case 20:
                        case 21:
                        case 22:
                            World[j, i] = new Human();
                            break;

                        case 30:
                        case 31:
                        case 32:
                            World[j, i] = new Elf();
                            break;

                        case 40:
                        case 41:
                        case 42:
                            World[j, i] = new Dwarf();
                            break;

                        case 50:
                        case 51:
                        case 52:
                            World[j, i] = new Hobbit();
                            break;

                        case 60:
                        case 61:
                        case 62:
                            World[j, i] = new Orc();
                            break;

                           
                    }


                }
            }
        }
   

   
       
    public static bool IsOccupied()
        {
            bool occupied = false;
            if (!(World[_PlayerLocation._x, _PlayerLocation._y] == null))
                return occupied = true;

            return occupied;
        }

    public static void SetCurrentLocation(Location location)
        {
            _PlayerLocation = location;
        }
    
    public static string ReturnEntity()
        {
          return  World[_PlayerLocation._x, _PlayerLocation._y].ToString();

        }

    public static void DeleteEntity()
        {
            World[_PlayerLocation._x, _PlayerLocation._y] = null;

        }


    }
}

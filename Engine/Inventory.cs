using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Engine
{
   public class Inventory
    {
        List<Item> _inventoryItems = new List<Item>();
        Player player;

        
    public bool AddToInventory(Item item, Character character)
        {

            if (IsCategoryPresent(item.GetItemCategory()))
                return false;

            else
            {
                _inventoryItems.Add(item);

                character._defence += item._ItemDefence;
                character._attack += item._ItemAttack;
                return true;
            }
          
 
        }

    public void RevomeFromInventory(Item item)
        {
      
           foreach(Item i in _inventoryItems)
            {             
                if(i.GetItemCategory()== item.GetItemCategory())
                {
                    _inventoryItems.Remove(i);
                    break;
            
                }            
            }
        }

    public int TotalWeight()
        {
            int total = 0;
           
            foreach(Item item in _inventoryItems)
            {
                total += item._ItemWeight;
            }

            return total;
        }

    public List<Item> ReturnInventory()
        {
            return _inventoryItems;
        }


    public bool IsCategoryPresent(ItemCategory cat)
        {
            bool IsPresent =false;

            foreach(Item i in _inventoryItems)
            {
                if(i.GetItemCategory() == cat)
                {
                    IsPresent = true;
                    return IsPresent;
                }
            }

            return IsPresent;

        }

    }
}

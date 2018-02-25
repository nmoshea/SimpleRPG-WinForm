using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NotStrongEnoughException:Exception
    {

      public NotStrongEnoughException() 
        {

        }

     public NotStrongEnoughException(string message) :base(message)
        {

        }


    }
}

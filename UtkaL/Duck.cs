using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtkaL
{
    public abstract class Duck
    {
      
        public string Swim()
        {
            return "swim" + this.GetType();
        }
        public abstract string Display();
    }
}

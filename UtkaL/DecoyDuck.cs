using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtkaL
{
     public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
          //  return "display" + this.GetType();
        }
    }
}
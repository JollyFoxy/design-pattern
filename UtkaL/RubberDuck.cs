using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtkaL
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
 //           return "display" + this.GetType();
        }
    }
}

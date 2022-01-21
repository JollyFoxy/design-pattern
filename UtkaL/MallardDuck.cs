using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtkaL
{
    public class MallardDuck : Duck, IFlyable, IQuackble
    {
        public override string Display()
        {
            return "display" + this.GetType();
        }

        public string fly()
        {
            return "fly" + this.GetType();
        }

        public string quack()
        {
            return "quack" + this.GetType();
        }
    }
}

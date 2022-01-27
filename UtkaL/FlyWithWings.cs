using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtkaL
{
    public class FlyWithWings : IFlyBehavior
    {
        public string fly()
        {
            return "Хлоп хлоп хлроп" + this.GetType();
        }
    }
}

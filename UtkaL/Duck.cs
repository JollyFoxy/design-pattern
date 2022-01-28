using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtkaL
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public string Swim()
        {
            return "Буль буль буль" + this.GetType();
        }
        public string Display()
        {
            return this.GetType() + " " + flyBehavior.fly() + " " + quackBehavior.quack();
        }
       /* public string quack()
        {
            return quackBehavior.quack();
        }
        public string fly()
        {
            return flyBehavior.fly(); 
        }*/
    }
}

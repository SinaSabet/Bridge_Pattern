using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Abstraction
    {
        private Implementor implementor;
        public Abstraction()
        {
            implementor=new ConcreateImplementor();
        }
        public virtual void Function()
        {
            implementor.Implemention();
        }
    }
    public class RefinedAbstraction : Abstraction { }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Implementor
    {
        public abstract void Implemention();
    }
    public class ConcreateImplementor : Implementor
    {
        public override void Implemention()
        {
            Console.WriteLine("Run from ConcreateImplementor1 .......");
        }
    }
    public class ConcreateImplementor2 : Implementor
    {
        public override void Implemention()
        {
            Console.WriteLine("Run from ConcreateImplementor2 .......");
        }
    }
}

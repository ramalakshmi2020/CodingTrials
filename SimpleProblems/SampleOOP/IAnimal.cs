using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleOOP
{
    interface IAnimal
    {
        public string Name { get; }
        public string Sound { get; }

        public virtual void Action() { }


    }
}

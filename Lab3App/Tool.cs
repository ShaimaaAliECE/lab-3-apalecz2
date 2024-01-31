using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Tool : Collectable
    {

        public abstract void DoAction();

        public abstract override void AddMe(List<Collectable> list);
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract internal class Collectable : Displayable
    {

        public CollectionBoard Board;

        public string Description = "Coin";

        public abstract void AddMe(List<Collectable> list);

        public abstract void Display();

    }
}

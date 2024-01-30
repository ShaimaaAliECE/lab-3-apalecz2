using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3App
{
    internal class Axe : Tool
    {
        private string name;
        
        public Axe(string name)
        {
            this.name = name;
        }

        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine(name + " Collected, Congrats!!!!");
            list.Add(this);
            DoAction();
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + name + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is used");
        }
    }
}

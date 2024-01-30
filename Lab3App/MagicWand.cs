using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        private string name;

        public MagicWand(string name)
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
            Console.WriteLine("Magic Wand " + name + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Magic Wand is used");
        }

        
    }
}

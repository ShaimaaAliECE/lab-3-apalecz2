using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Diamond : Treasure
    {

        private string name;
        private int score;

        public Diamond(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine(name + " Collected, Congrats!!!!");
            UpdateTotalScore();
            list.Add(this);
        }

        public override void Display()
        {
            Console.WriteLine("Diamond" + name + " is displayed");
        }

        public override void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += score;
            Console.WriteLine("Total Score is updated to: " + CollectionBoard.TotalScore);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {

        private string name;
        private int score;
        private int value;

        public Coin(string name, int score, int value)
        {
            this.score = score;
            this.value = value;
            this.name = name;
        }


        public void UpdateTotalValue()
        {
            CollectionBoard.TotalValue += value;
            Console.WriteLine("Total Value is updated to: " + CollectionBoard.TotalValue);
        }

        public override void Display()
        {
            Console.WriteLine(Description + " " + name + " is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine(name + " Collected, Congrats!!!!");
            UpdateTotalScore();
            UpdateTotalValue();
            list.Add(this);
        }

        public override void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += score;
            Console.WriteLine("Total Score is updated to: " + CollectionBoard.TotalScore);
        }
    }
}

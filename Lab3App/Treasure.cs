using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Treasure : Collectable 
    {

        public int Score = CollectionBoard.TotalScore;

        public abstract void UpdateTotalScore();
        public abstract override void AddMe(List<Collectable> list);

        public abstract override void Display();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.PlayerClass
{
    public class Cowboy : PlayerClass
    {
        public Cowboy()
        {
            this.HP = 10;
            this.Defence = 1;//lower scaling Defence
            this.Damage = 2;//higher scaling Damage
            this.DamageModifier = 0;
            this.ClassType = "Cowboy";
            this.XPLevel = 1;
        }
    }
}

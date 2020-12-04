using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.PlayerClass
{
    public class Ninja : PlayerClass
    {
        public Ninja()
        {
            //lvl 1
            this.HP = 11;
            this.Defence = 3; //higher scaling defence
            this.Damage = 2; //lower scaling attack
            this.DamageModifier = 1;
            this.ClassType = "Ninja";
            this.XPLevel = 1;
        }
    }
}

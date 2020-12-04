using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.PlayerClass
{
    public abstract class BadGuys : IEntities
    {
        public int HP { get; set; }
        public int Defence { get; set; }
        public int Damage { get; set; }
        public int DamageModifier { get; set; } //might put this in weapons
        public int XPLevel { get; set; }
        public string Name { get; set; }

        public BadGuys()
        {
            //basic enemy
            this.HP = 6;
            this.Defence = 0;
            this.Damage = 2;
            this.DamageModifier = 0;
            this.XPLevel = 1;
            this.Name = "Angry Cowboy";
        }
    }
}

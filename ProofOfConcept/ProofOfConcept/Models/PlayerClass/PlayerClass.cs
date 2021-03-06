﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.PlayerClass
{
    public abstract class PlayerClass : IEntities
    {
        public int HP { get; set; }
        public int Defence { get; set; }
        public int Damage { get; set; }
        public int DamageModifier { get; set; } //might put this in weapons
        public string ClassType { get; set; }
        public int XPLevel { get; set; }

        public PlayerClass()
        {
            this.HP = 10;
            this.Defence = 2;
            this.Damage = 2;
            this.DamageModifier = 0;
            this.ClassType = "No Class";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.Weapons
{
    public class NinjaSword : Weapon
    {
        public NinjaSword()
        {
            this.Name = "Sword";
            this.Type = "Ninja";
            this.Verb = "slash";
            this.Damage = 4;
        }
    }
}

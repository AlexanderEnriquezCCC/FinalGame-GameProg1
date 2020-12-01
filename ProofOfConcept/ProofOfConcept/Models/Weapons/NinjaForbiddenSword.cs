using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.Weapons
{
    public class NinjaForbiddenSword : Weapon
    {
        public NinjaForbiddenSword()
        {
            this.Name = "Forbidden Sword";
            this.Damage = 8;
            this.Verb = "slash";
            this.Type = "Ninja";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.Weapons
{
    public class CowboyGun : Weapon
    {
        public CowboyGun()
        {
            this.Name = "Gun";
            this.Damage = 5;
            this.Verb = "Shoot";
            this.Type = "Cowboy";
        }
    }
}

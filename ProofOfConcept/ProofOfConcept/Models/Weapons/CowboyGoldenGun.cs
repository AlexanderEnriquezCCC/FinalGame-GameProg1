using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.Weapons
{
    public class CowboyGoldenGun : Weapon
    {
        public CowboyGoldenGun()
        {
            this.Name = "Golden Gun";
            this.Damage = 10;
            this.Verb = "Shoot"; //same as parent
            this.Type = "Cowboy"; //same as parent
        }
    }
}

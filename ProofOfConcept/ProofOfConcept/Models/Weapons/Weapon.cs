using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        public int Damage { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Verb { get; set; }

        public Weapon()
        {
            this.Name = "Gun";
            this.Damage = 5;
            this.Verb = "Shoot";
            this.Type = "Cowboy";
        }

        public string Use()
        {
            return $"You {this.Verb} the {this.Name}";
        }
    }
}

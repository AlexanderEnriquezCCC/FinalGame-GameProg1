using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.Weapons
{
    interface IWeapon
    {
        int Damage { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        string Verb { get; set; }

    }
}

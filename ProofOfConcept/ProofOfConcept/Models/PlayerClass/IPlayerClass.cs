using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Models.PlayerClass
{
    interface IPlayerClass
    {
        int HP { get; set; }
        int Defence { get; set; }
        int Damage { get; set; }
        int DamageModifier { get; set; } //might put this in weapons


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Pokemon
{
    public class Attack
    {
        public int Damage { get; set; }

        public Attack(int damage) {
            Damage = damage;
        }
    }
}

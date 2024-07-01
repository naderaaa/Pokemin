using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Pokemon
{
    public class PokemonEvents
    {
        public EventHandler<Attack>? OnAttackStart;

        public EventHandler<Attack>? OnAttackEnd;

        public EventHandler<Attack>? OnTakeDamageStart;

        public EventHandler<Attack>? OnTakeDamageEnd;

        public PokemonEvents() { }
    }
}

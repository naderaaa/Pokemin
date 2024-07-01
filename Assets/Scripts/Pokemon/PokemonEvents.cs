using System;

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

using System;

public class Team//two Teams per game
{
    public string Name { get; set; }//name of the Team

    public int MaxEnergy { get; protected set; } = 6;

    public int Energy
    {
        get => _Energy; set
        {
            _Energy = value;
            EnergyUpdated?.Invoke(this, value);
        }
    }

    private int _Energy = 0;

    public static EventHandler<int>? EnergyUpdated { get; set; }

    public int NumPokemon
    {
        get => _NumPokemon; set
        {
            _NumPokemon = value;
            PokemonCountUpdated?.Invoke(this, value);
        } // the number of pokemon is incremented on purchase, decremented on death
    }

    private int _NumPokemon = 0;

    public static EventHandler<int>? PokemonCountUpdated { get; set; }

    public Team(string name)
    {
        this.Name = name;
    }

}

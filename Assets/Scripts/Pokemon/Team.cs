public class Team//two Teams per game
{
    public string Name { get; set; }//name of the Team

    public int MaxEnergy { get; protected set; } = 20; // set to 6

    public int Energy { get; set; }

    public int NumPokemon { get; set; } = 0;
    public Team(string name)
    {
        this.Name = name;
    }

}

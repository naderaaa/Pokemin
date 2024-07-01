public class Team//two Teams per game
{
    public string Name { get; set; }//name of the Team

    public int MaxEnergy { get; protected set; } = 6;

    public int Energy { get; set; }
    public Team(string name)
    {
        this.Name = name;
    }

}

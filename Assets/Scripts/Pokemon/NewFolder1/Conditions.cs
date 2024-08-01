public class Conditions
{
    public string name;
    public string description;
    public bool isPositive; // false when a negative effect
}

public class Speedy : Conditions
{
    public Speedy()
    {
        name = "Speedy";
        description = "+1 speed!";
        isPositive = true;
    }
}
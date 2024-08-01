public class Intimidate : PassiveAbility
{
    public Intimidate(Piece piece)
    {
        Name = "Intimidate";
        Description = "Enemies in this pokemons range deal -2 damage";
        Owner = piece;
    }

    // im not exactly sure how i want this to work
}

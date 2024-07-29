using UnityEngine;

public class Mawile : Piece
{
    public Mawile()
    {
        Tier = 2;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Mawile);

    }
    public override string GetContents()
    {
        return "mawile";
    }
}

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

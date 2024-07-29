using UnityEngine;

public class Whimsicott : Piece
{
    public Whimsicott()
    {
        Tier = 4;
        MaxHP = 10;
        HP = MaxHP;

        Atk = 5;
        Speed = 2;
        Range = 2;
        Steps = Speed;

        Abilities[0] = new Tailwind(this);

        PreEvolution = new Cottonee();
        Sprite = Resources.Load<Sprite>(FilePaths.Whimsicott);
        Scale = 1.2f;

    }

    public override string GetContents()
    {
        return "whimsicott";
    }
}
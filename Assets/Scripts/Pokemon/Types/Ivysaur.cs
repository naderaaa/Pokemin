using UnityEngine;

public class Ivysaur : Piece
{
    public Ivysaur()
    {
        Tier = 2;

        MaxHP = 10;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Ivysaur);
        PreEvolution = new Bulbasaur();

        Scale = 1.1f;
    }

    public override string GetContents()
    {
        return "ivysaur";
    }
}

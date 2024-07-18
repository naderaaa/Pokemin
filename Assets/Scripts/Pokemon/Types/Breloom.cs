using UnityEngine;

public class Breloom : Piece
{
    public Breloom()
    {
        Tier = 3;
        MaxHP = 10;
        HP = MaxHP;
        Atk = 7;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Breloom);

    }

    public override string GetContents()
    {
        return "breloom";
    }
}

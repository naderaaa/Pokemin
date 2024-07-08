using UnityEngine;

public class Sneasel : Piece
{
    public Sneasel()
    {
        Tier = 3;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 5;
        Speed = 2;
        Range = 1;
        Steps = Speed;

        Scale = 1.5f;

        Sprite = Resources.Load<Sprite>(FilePaths.Sneasel);
    }

    public override string GetContents()
    {
        return "sneasel";
    }

}

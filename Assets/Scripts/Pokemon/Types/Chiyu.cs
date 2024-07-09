using UnityEngine;

public class Chiyu : Piece
{
    public Chiyu()
    {
        Tier = 6;

        MaxHP = 12;
        HP = MaxHP;

        Atk = 7;
        Speed = 2;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Chiyu);

        Scale = 1.2f;
    }

    public override string GetContents()
    {
        return "chi-yu";
    }
}

using UnityEngine;

public class Latias : Piece
{
    public Latias()
    {
        Tier = 5;

        MaxHP = 13;
        HP = MaxHP;

        Atk = 5;
        Speed = 2;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Latias);
        Scale = 1.5f;

    }

    public override string GetContents()
    {
        return "latias";
    }

}

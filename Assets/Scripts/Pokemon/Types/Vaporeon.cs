using UnityEngine;

public class Vaporeon : Piece
{
    public Vaporeon()
    {
        Tier = 4;
        MaxHP = 13;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Vaporeon);
        Scale = 1.2f;

    }
    public override string GetContents()
    {
        return "vaporeon";
    }
}

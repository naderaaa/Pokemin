using UnityEngine;

public class Corphish : Piece
{
    public Corphish()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Corphish);

        Scale = 1.1f;
    }
    public override string GetContents()
    {
        return "corphish";
    }
}

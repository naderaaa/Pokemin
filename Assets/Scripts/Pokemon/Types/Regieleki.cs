using UnityEngine;

public class Regieleki : Piece
{
    public Regieleki()
    {
        Tier = 6;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 7;
        Speed = 4;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Regieleki);
    }

    public override string GetContents()
    {
        return "regieleki";
    }

}

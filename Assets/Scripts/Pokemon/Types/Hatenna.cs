using UnityEngine;

public class Hatenna : Piece
{
    public Hatenna()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Hatenna);

        Scale = 1.1f;

    }

    public override string GetContents()
    {
        return "hatenna";
    }
}

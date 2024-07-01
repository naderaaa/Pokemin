using UnityEngine;

public class Tinkatink : Piece
{
    public Tinkatink()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Tinkatink);

    }
    public override string GetContents()
    {
        return "tinkatink";
    }
}

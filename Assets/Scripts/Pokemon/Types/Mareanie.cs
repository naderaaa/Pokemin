using UnityEngine;

public class Mareanie : Piece
{
    public Mareanie()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Mareanie);

    }

    public override string GetContents()
    {
        return "mareanie";
    }
}

using UnityEngine;

public class Dreepy : Piece
{
    public Dreepy()
    {
        Tier = 1;

        MaxHP = 6;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Dreepy);

    }
    public override string GetContents()
    {
        return "dreepy";
    }
}

using UnityEngine;

public class Jirachi : Piece
{
    public Jirachi()
    {
        Tier = 5;

        MaxHP = 13;
        HP = MaxHP;

        Atk = 5;
        Speed = 2;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Jirachi);

        Scale = 1.2f;

    }

    public override string GetContents()
    {
        return "jirachi";
    }
}
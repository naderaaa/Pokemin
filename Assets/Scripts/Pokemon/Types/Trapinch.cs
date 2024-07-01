using UnityEngine;

public class Trapinch : Piece
{
    public Trapinch()
    {
        Tier = 2;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 6;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Scale = 1.3f;
        Sprite = Resources.Load<Sprite>(FilePaths.Trapinch);

    }

    public override string GetContents()
    {
        return "trapinch";
    }
}

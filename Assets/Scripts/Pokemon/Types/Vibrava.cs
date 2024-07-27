using UnityEngine;

public class Vibrava : Piece
{
    public Vibrava()
    {
        Tier = 3;
        MaxHP = 9;
        HP = MaxHP;

        Atk = 5;
        Speed = 2;
        Range = 2;
        Steps = Speed;

        PreEvolution = new Trapinch();
        Sprite = Resources.Load<Sprite>(FilePaths.Vibrava);
        Scale = 1.2f;
    }

    public override string GetContents()
    {
        return "vibrava";
    }
}
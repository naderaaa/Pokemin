using UnityEngine;

public class Shaymin : Piece
{
    public Shaymin()
    {
        Tier = 5;

        MaxHP = 13;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Shaymin);

    }

    public override string GetContents()
    {
        return "shaymin";
    }
}
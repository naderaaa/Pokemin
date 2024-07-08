using UnityEngine;

public class Dratini : Piece
{

    public Dratini()
    {
        Tier = 1;

        MaxHP = 7;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Scale = 1f;
        Sprite = Resources.Load<Sprite>(FilePaths.Dratini);


    }
    public override string GetContents()
    {
        return "dratini";
    }
}

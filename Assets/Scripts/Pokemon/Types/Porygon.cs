using UnityEngine;

public class Porygon : Piece
{
    public Porygon()
    {
        Tier = 2;

        MaxHP = 10;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Porygon);

        Scale = 1.2f;
    }
    public override string GetContents()
    {
        return "porygon";
    }
}

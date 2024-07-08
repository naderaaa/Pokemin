using UnityEngine;

public class Litwick : Piece
{
    public Litwick()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Litwick);
        Scale = 1.2f;

    }
    public override string GetContents()
    {
        return "litwick";
    }
}

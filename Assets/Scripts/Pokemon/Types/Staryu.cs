using UnityEngine;

public class Staryu : Piece
{
    public Staryu()
    {
        Tier = 2;

        MaxHP = 7;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Staryu);
        Scale = 1.2f;
    }
    public override string GetContents()
    {
        return "staryu";
    }
}

using UnityEngine;

public class Diancie : Piece
{
    public Diancie()
    {
        Tier = 5;
        MaxHP = 15;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Diancie);

    }

    public override string GetContents()
    {
        return "diancie";
    }
}

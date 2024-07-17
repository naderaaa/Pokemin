using UnityEngine;

public class Deino : Piece
{
    public Deino()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Deino);

        Scale = 1.2f;
    }

    public override string GetContents()
    {
        return "deino";
    }
}

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

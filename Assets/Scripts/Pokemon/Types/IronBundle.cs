using UnityEngine;

public class IronBundle : Piece
{
    public IronBundle()
    {
        Tier = 5;
        MaxHP = 9;
        HP = MaxHP;

        Atk = 6;
        Speed = 2;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.IronBundle);
        Scale = 1.2f;
    }

}

using UnityEngine;

public class IronValiant : Piece
{
    public IronValiant()
    {
        Tier = 5;

        MaxHP = 10;
        HP = MaxHP;
        Atk = 7;
        Speed = 2;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.IronValiant);
    }

}

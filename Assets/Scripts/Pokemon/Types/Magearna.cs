using UnityEngine;

public class Magearna : Piece
{
    public Magearna()
    {
        Tier = 6;

        MaxHP = 14;
        HP = MaxHP;

        Atk = 7;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Magearna);
    }

}
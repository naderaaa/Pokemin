using UnityEngine;

public class SlitherWing : Piece
{
    public SlitherWing()
    {
        Tier = 5;

        MaxHP = 13;
        HP = MaxHP;

        Atk = 8;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Scale = 1.5f;

        Sprite = Resources.Load<Sprite>(FilePaths.SlitherWing);
    }

}

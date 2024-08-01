using UnityEngine;

public class Victini : Piece
{
    public Victini()
    {
        Tier = 5;
        MaxHP = 13;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Victini);
    }

}

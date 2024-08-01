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

}

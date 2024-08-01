using UnityEngine;

public class Bulbasaur : Piece
{
    public Bulbasaur()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;
        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Scale = 1.2f;
        Sprite = Resources.Load<Sprite>(FilePaths.Bulbasaur);

    }
}

using UnityEngine;

public class Mantyke : Piece
{
    public Mantyke()
    {
        Tier = 2;

        MaxHP = 10;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Mantyke);

    }

}
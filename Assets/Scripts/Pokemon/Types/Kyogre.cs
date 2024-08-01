using UnityEngine;

public class Kyogre : Piece
{
    public Kyogre()
    {
        Tier = 6;

        MaxHP = 14;
        HP = MaxHP;

        Atk = 7;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Kyogre);
        Scale = 1.6f;

    }

}
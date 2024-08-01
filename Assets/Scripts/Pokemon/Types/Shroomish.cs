using UnityEngine;

public class Shroomish : Piece
{
    public Shroomish()
    {
        Tier = 2;
        MaxHP = 9;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;



        Sprite = Resources.Load<Sprite>(FilePaths.Shroomish);

        Scale = 1.2f;
    }

}
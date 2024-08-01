using UnityEngine;

public class Glimmet : Piece
{
    public Glimmet()
    {
        Tier = 2;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Glimmet);
        Scale = 1.2f;
    }

}

using UnityEngine;

public class Porygon2 : Piece
{
    public Porygon2()
    {
        Tier = 4;

        MaxHP = 12;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Porygon2);
        Scale = 1.1f;

        PreEvolution = new Porygon();

    }

}
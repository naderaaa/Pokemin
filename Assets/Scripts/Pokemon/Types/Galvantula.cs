using UnityEngine;

public class Galvantula : Piece
{
    public Galvantula()
    {
        Tier = 3;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 5;
        Speed = 2;
        Range = 3;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Galvantula);
        Scale = 1.3f;

        PreEvolution = new Joltik();

    }

}

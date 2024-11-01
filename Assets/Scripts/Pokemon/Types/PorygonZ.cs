using UnityEngine;

public class PorygonZ : Piece
{
    public PorygonZ()
    {
        Tier = 5;

        MaxHP = 10;
        HP = MaxHP;

        Atk = 9;
        Speed = 1;
        Range = 3;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.PorygonZ);
        Scale = 1.2f;

        PreEvolution = new Porygon2();

    }

}

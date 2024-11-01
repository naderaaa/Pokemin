using UnityEngine;

public class Crustle : Piece
{
    public Crustle()
    {
        Tier = 3;

        MaxHP = 12;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Crustle);
        Scale = 1.3f;

        PreEvolution = new Dwebble();

    }

}

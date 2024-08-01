using UnityEngine;

public class Corsola : Piece
{
    public Corsola()
    {
        Tier = 2;
        MaxHP = 12;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Corsola);
    }

}

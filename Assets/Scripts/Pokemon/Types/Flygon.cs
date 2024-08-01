using UnityEngine;

public class Flygon : Piece
{
    public Flygon()
    {
        Tier = 4;

        MaxHP = 12;
        HP = MaxHP;

        Atk = 6;
        Speed = 2;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Flygon);
        PreEvolution = new Vibrava();
    }

}

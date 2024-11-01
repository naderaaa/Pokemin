using UnityEngine;

public class Glimmora : Piece
{
    public Glimmora()
    {
        Tier = 4;

        MaxHP = 11;
        HP = MaxHP;

        Atk = 7;
        Speed = 1;
        Range = 3;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Glimmora);
        Scale = 1.3f;

        PreEvolution = new Glimmet();

    }

}

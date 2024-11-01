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
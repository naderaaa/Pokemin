﻿using UnityEngine;

public class Hattrem : Piece
{
    public Hattrem()
    {
        Tier = 2; 
        MaxHP = 10;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Abilities[0] = new HealingWish(this);

        PreEvolution = new Hatenna();
        Sprite = Resources.Load<Sprite>(FilePaths.Hattrem);
        Scale = 1.3f;
    }

}

using UnityEngine;

public class Starmie : Piece
{
    public Starmie()
    {
        Tier = 4;
        MaxHP = 11;
        HP = MaxHP;
        Atk = 5;
        Speed = 2;
        Range = 2;
        Steps = Speed;
        Scale = 1.2f;

        PreEvolution = new Staryu();
        Sprite = Resources.Load<Sprite>(FilePaths.Starmie);
    }
    
}
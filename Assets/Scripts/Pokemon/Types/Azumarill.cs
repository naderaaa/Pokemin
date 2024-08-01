using UnityEngine;

public class Azumarill : Piece
{
    public Azumarill()
    {
        Tier = 3;
        MaxHP = 12;
        HP = MaxHP;
        Atk = 8;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Scale = 1.2f;

        PreEvolution = new Marill();
        Sprite = Resources.Load<Sprite>(FilePaths.Azumarill);
    }
}
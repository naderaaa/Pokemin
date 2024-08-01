using UnityEngine;

public class Wochien : Piece
{
    public Wochien()
    {
        Tier = 6;
        MaxHP = 14;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Wochien);
    }

}

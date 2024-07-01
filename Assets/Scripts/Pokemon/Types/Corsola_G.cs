using UnityEngine;

public class Corsola_G : Piece
{
    public Corsola_G()
    {

        Tier = 2;
        MaxHP = 12;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Corsola_G);
    }

    public override string GetContents()
    {
        return "Galarian Corsola";
    }

}

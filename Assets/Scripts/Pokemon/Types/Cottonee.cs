using UnityEngine;

public class Cottonee : Piece
{

    public Cottonee()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 2;
        Speed = 2;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Cottonee);
    }

    public override string GetContents()
    {
        return "cottonee";
    }
}

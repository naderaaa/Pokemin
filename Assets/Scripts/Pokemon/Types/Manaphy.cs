using UnityEngine;

public class Manaphy : Piece
{
    public Manaphy()
    {
        Tier = 5;

        MaxHP = 13;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Manaphy);
        Scale = 1.3f;

    }

    public override string GetContents()
    {
        return "manaphy";
    }

}

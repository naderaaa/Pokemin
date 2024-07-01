using UnityEngine;

public class Dwebble : Piece
{
    public Dwebble()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Dwebble);

    }

    public override string GetContents()
    {
        return "dwebble";
    }
}

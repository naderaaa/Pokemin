using UnityEngine;

public class Marill : Piece
{
    public Marill()
    {
        Tier = 2;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Marill);
    }
    public override string GetContents()
    {
        return "marill";
    }
}

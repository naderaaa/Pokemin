using UnityEngine;

public class Azurill : Piece
{


    public Azurill()
    {
        Tier = 1;

        MaxHP = 7;
        HP = MaxHP;
        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;


        Sprite = Resources.Load<Sprite>(FilePaths.Azurill);

    }

    public override string GetContents()
    {
        return "azurill";
    }


}

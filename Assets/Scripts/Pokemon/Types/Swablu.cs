using UnityEngine;

public class Swablu : Piece
{
    public Swablu()
    {
        Tier = 1;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Swablu);

    }
    public override string GetContents()
    {
        return "swablu";
    }
}

using UnityEngine;

public class Altaria : Piece
{
    public Altaria()
    {
        Tier = 3;

        MaxHP = 12;
        HP = MaxHP;
        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        PreEvolution = new Swablu();
        Sprite = Resources.Load<Sprite>(FilePaths.Altaria);

    }

    public override string GetContents()
    {
        return "altaria";
    }
}
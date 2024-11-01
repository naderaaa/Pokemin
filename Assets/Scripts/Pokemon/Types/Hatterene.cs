using UnityEngine;

public class Hatterene : Piece
{
    public Hatterene()
    {
        Tier = 4;
        MaxHP = 12;
        HP = MaxHP;

        Atk = 7;
        Speed = 1;
        Range = 3;
        Steps = Speed;

        Abilities[0] = new HealingWish(this);

        PreEvolution = new Hattrem();
        Sprite = Resources.Load<Sprite>(FilePaths.Hatterene);
        Scale = 1.2f;
    }

}

using Assets.Scripts.Pokemon;
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

        Events.OnTakeDamageStart += (object? sender, Attack Attack) =>
        {
            Debug.Log($"Taking {Attack.Damage} damage");
            Attack.Damage = 0;
            Debug.Log($"But swablu is invulnerable so attack damage was reduced to {Attack.Damage}");
        };

    }

    public override string GetContents()
    {
        return "swablu";
    }
}

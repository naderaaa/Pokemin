using System.Buffers;

public class HealingWish : ActiveAbility
{
    public HealingWish(Piece piece)
    {
        Name = "Healing Wish";
        Description = "This pokemon sacrifices itself to give the player 4 energy";
        cost = 0;
        Owner = piece;
    }

    public override void OnUse()
    {

        // killing itself (womp)
        Owner.HP = 0;
        Owner.Team.NumPokemon--;
        Owner.Location.SetPiece(null);
        GameManager.Instance.board.ClearHighlightsAndTargets();
        InfoUI.Instance.CloseUI();

        // hilariously broken (but i'll keep it this way for now)
        Owner.Team.Energy += 4;
    }
}

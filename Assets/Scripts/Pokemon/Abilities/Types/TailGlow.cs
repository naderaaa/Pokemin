public class TailGlow : ActiveAbility
{
    public TailGlow(Piece piece)
    {
        Name = "Tail Glow";
        Description = "This pokemon's attack damage is increased by 4";
        cost = 3;
        Owner = piece;
    }
    
    public override void OnUse()
    {
        Owner.Atk += 4;
        InfoUI.Instance.CloseUI();
        InfoUI.Instance.OpenUI(Owner);
        if (GameManager.whosTurn.Energy >= cost)
        {
            GameManager.whosTurn.Energy -= cost;
        }
    }
}
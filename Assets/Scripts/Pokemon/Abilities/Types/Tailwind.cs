public class Tailwind : ActiveAbility
{
    public Tailwind(Piece piece)
    {
        Name = "Tailwind";
        Description = "All of this pokemon's allies gain +1 speed until the end of the turn";
        cost = 2;
        Owner = piece;
    }
    public override void OnUse()
    {
        if (Owner.Team.Energy >= cost)
        {
            foreach (Piece p in Owner.Team.pokemon)
            {
                p.Steps++;
            }
            Owner.Team.Energy -= cost;

            InfoUI.Instance.Reload();
        }
    }
}
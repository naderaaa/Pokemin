public class Intimidate : PassiveAbility
{
    public Intimidate(Piece piece)
    {
        Name = "Intimidate";
        Description = "Enemies in this pokemons range deal -2 damage";
        Owner = piece;
    }

    public override void OnUse()
    {
        for (int i = -Owner.Range; i < Owner.Range; i++)
        {
            for (int j = -Owner.Range; j < Owner.Range; j++)
            {
                if (Owner.Location.posx + i < 9 && Owner.Location.posx + i >= 0 && Owner.Location.posy + j < 9 && Owner.Location.posy + j >= 0)
                {
                    if (!GameManager.Instance.board.tiles[Owner.Location.posx + i, Owner.Location.posy + j].pieceOnTile.Team.Equals(Owner.Team))
                    {
                        GameManager.Instance.board.tiles[Owner.Location.posx + i, Owner.Location.posy + j].pieceOnTile.Atk = GameManager.Instance.board.tiles[Owner.Location.posx + i, Owner.Location.posy + j].pieceOnTile.Atk - 2;
                    } else
                    {
                        // reset attack to how it was normally
                            

                    }


                }
                
            }
        }
        // activated in certain situations
    }    
    // im not exactly sure how i want this to work
}

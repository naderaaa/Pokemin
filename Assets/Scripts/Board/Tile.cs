using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public int posx; // x position in grid
    public int posy; // y position in grid
#nullable enable
    public Piece? pieceOnTile; // null when tile is empty, otherwise holds a pokemon
#nullable disable
    public bool merge = true; // :3
    public Image displayImage; // the image on display
    public Image teamSymbol; // how teams are represented on the board
    public Image targetOverlay; // red circle
    public bool attacked = false; // whether or not the piece has already attacked

    public bool doJump = false;
    public float frequency = 4f;
    public Vector3 originalPosition;

    //private void Update()
    //{ 
    //
    //    if (pieceOnTile != null)
    //    {
    //        if (doJump)
    //        {
    //            float newY = originalPosition.y + (Mathf.Sin(Random.value + Time.time * frequency) * .03f);
    //            displayImage.transform.localPosition = new Vector3(displayImage.transform.localPosition.x, newY, displayImage.transform.localPosition.z);
    //            if (Mathf.Sin(Random.value + Time.time * frequency) < 0) {
    //                doJump = false;
    //            }
    //            Debug.Log("did");
    //        }
    //        else if (Mathf.Sin(Random.value + Time.time * frequency) >= 0)
    //        {
    //            Debug.Log("gonna do");
    //
    //            doJump = true;
    //        }
    //
    //
    //    }
    //}




    public void PosGeneration() // generates the position relative to the scene using a formula
    {
        Vector3 pos = new((posx * 109) + 111, (posy * 109) + 100, gameObject.transform.position.z);
        originalPosition = pos;
        gameObject.transform.position = pos; // using a vector
    }

    public void SetPiece(Piece piece) // sets piece and affects the sprite
    {
        if (piece == null)  // case for deleting contents
        {
            displayImage.enabled = false;
            displayImage.sprite = null;
            pieceOnTile = null;
            teamSymbol.enabled = false;
        }
        else // actually adding
        {
            pieceOnTile = piece;
            displayImage.enabled = true;
            displayImage.sprite = piece.Sprite;
            displayImage.transform.localScale = new Vector3(piece.Scale, piece.Scale, piece.Scale);
            if (piece.Team == GameManager.teams.Item1)
            {
                teamSymbol.sprite = Resources.Load<Sprite>(FilePaths.Team1Flag);
            }
            else
            {
                teamSymbol.sprite = Resources.Load<Sprite>(FilePaths.Team2Flag);
            }
            teamSymbol.enabled = true;
        }

    }

    public void TileSelected() // the onclick method for a tile
    {
        if (ShopPanel.buying && Shop.ShopInstance.ItemToPurchase != null) // either youre making a purchase
        {
            PlacingPieceOrItem();
        }
        else // or selecting a tile
        {
            GameManager.Instance.board.SelectTile(this);
        }
    }

    public void PlacingPieceOrItem()
    {
        switch (Shop.ShopInstance.ItemToPurchase.shopItem)
        {
            case Piece piece when pieceOnTile == null: // if the shopitem is a piece
                if (GameManager.whosTurn == GameManager.teams.Item1)
                {
                    if (posy == 0 || posy == 1) // team1 places new pokemon in the bottom two rows
                    {
                        BuyingAPokemon(piece);
                    }
                }
                else
                {
                    if (posy == 7 || posy == 8) // team2 places new pokemon in the top two rows
                    {
                        BuyingAPokemon(piece);
                    }
                }
                break;
            case Piece piece when piece.PreEvolution != null && pieceOnTile.GetContents() == piece.PreEvolution.GetContents() && pieceOnTile.Team == GameManager.whosTurn: // if the shopitem is an evolution
                if (GameManager.whosTurn.Energy >= 2) // if the piece can be purchased
                {
                    piece.Team = GameManager.whosTurn;
                    // once conditions are set up, the evolution should get the preevos conditions here
                    SetPiece(piece);
                }
                Shop.ShopInstance.ItemToPurchase.AfterPurchase();
                break;

            case Item item when pieceOnTile != null: // if the shopitem is an item
                // figure this out later
                break;
        }
    }
    public void BuyingAPokemon(Piece piece) // figure this out lol
    {
        if (GameManager.whosTurn.Energy >= 2 && GameManager.whosTurn.NumPokemon < GameManager.MAX_POKEMON) // if the piece can be purchased
        {
            piece.Team = GameManager.whosTurn;
            SetPiece(piece);
        }
        Shop.ShopInstance.ItemToPurchase.AfterPurchase();

    }

}


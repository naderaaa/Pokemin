using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
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

    public void PosGeneration() // generates the position relative to the scene using a formula
    {
        Vector3 pos = new((posx * 109) + 111, (posy * 109) + 100, gameObject.transform.position.z);
        gameObject.transform.position = pos; // using a vector
    }

    public void SetPiece(Piece piece) // sets piece and affects the sprite
    {
        if (piece == null)  // case for deleting contents
        {
            displayImage.enabled = false;
            displayImage.sprite = null;
            this.pieceOnTile = null;
        }
        else // actually adding
        {
            this.pieceOnTile = piece;
            displayImage.enabled = true;
            displayImage.sprite = piece.Sprite;
            displayImage.transform.localScale = new Vector3(piece.Scale, piece.Scale, piece.Scale);
        }

    }

    public void TileSelected() // the onclick method for a tile
    {
        Debug.Log(GameManager.whosTurn.Energy); // remove once energy display works

        if (ShopPanel.buying && Shop.ShopInstance.ItemToPurchase != null) // either your making a purchase
        {
            BuyingAnItem();
        } 
        else // or selecting a tile
        {
            GameManager.Instance.board.SelectTile(this);
        }
    }

    public void BuyingAnItem() 
    {
        if (GameManager.whosTurn == GameManager.teams.Item1)
        {
            if (posy == 0 || posy == 1) // team1 places new pokemon in the bottom two rows
            {
                PlacingPieceOrItem();
            }
        }
        else
        {
            if (posy == 7 || posy == 8) // team2 places new pokemon in the top two rows
            {
                PlacingPieceOrItem();
            }
        }
    }

    public void PlacingPieceOrItem()
    {
        switch (Shop.ShopInstance.ItemToPurchase.shopItem)
        {
            case Piece piece when pieceOnTile == null: // if the shopitem is a piece
                if (GameManager.whosTurn.Energy >= 2 && GameManager.whosTurn.NumPokemon < GameManager.MAX_POKEMON) // if the piece can be purchased
                {
                    piece.Team = GameManager.whosTurn; 
                    SetPiece(piece);
                }
                Shop.ShopInstance.ItemToPurchase.AfterPurchase();
                break;

            case Item item when pieceOnTile != null: // if the shopitem is an item
                // figure this out later
                break;
        }
    }
    
}


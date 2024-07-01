using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public int posx; // x position in grid
    public int posy; // y position in grid
#nullable enable
    public Piece? pieceOnTile; // null when tile is empty, otherwise holds a pokemon
#nullable disable
    public Image displayImage; // the image on display
    public Image teamSymbol; // how teams are represented on the board
    public Image targetOverlay; // red circle
    //public bool highlighted = false; // a highlighted tile is empty and a pokemon is moved to that tile when clicked
    //public bool targeted = false; // if true, will be attacked on click
    public bool attacked = false; // whether or not the piece has already attacked
    //public static bool selected = false; // any piece is currently selected (move to board)
    //public Tile CurrentlyControlingTile; // handles moving

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
        GameManager.Instance.board.SelectTile(this);
    }
}

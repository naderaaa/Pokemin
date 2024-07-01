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

        // KEEP THIS in case the refactoring is still buggy (highly likely)

        //Debug.Log(GameManager.whosTurn.Energy);
        //
        //// case 1: selecting a tile with steps
        //// case 2: selecting a tile without steps (just targeting)
        //// case 3: deselecting a tile by clicking on a non highlighted tile
        //// case 4: deselecting a tile by clicking on the selected tile
        //// case 5: moving by clicking a highlighted tile
        //// case 6: attacking normally
        //// case 7: targeting an ability
        //
        //if (highlighted) // moving by clicking a highlighted tile
        //{
        //    GameManager.Instance.board.ClearHighlightsAndTargets();
        //    SetPiece(CurrentlyControlingTile.pieceOnTile); // move piece over
        //    CurrentlyControlingTile.SetPiece(null); // delete old location
        //    highlighted = false; // unhighlight the tile
        //    selected = false;
        //    if (pieceOnTile.Steps == pieceOnTile.Speed)
        //        GameManager.whosTurn.Energy--;
        //    pieceOnTile.Steps--; // decrements steps
        //    Debug.Log(GameManager.whosTurn.Energy);
        //
        //}
        //else if (targeted) // attacking normally
        //{
        //    GameManager.Instance.board.ClearHighlightsAndTargets();
        //    selected = false;
        //    CurrentlyControlingTile.pieceOnTile.Steps = 0;
        //    CurrentlyControlingTile.attacked = true;
        //    CurrentlyControlingTile.pieceOnTile.Attack(pieceOnTile);
        //    if (pieceOnTile.HP <= 0)
        //    {
        //        pieceOnTile = null;
        //        SetPiece(null);
        //    }
        //    GameManager.whosTurn.Energy--;
        //    Debug.Log(GameManager.whosTurn.Energy);
        //}
        //else if (pieceOnTile == null) // deselecting a tile by clicking on a non highlighted tile
        //{
        //    GameManager.Instance.board.ClearHighlightsAndTargets();
        //    selected = false;
        //
        //}
        //else if (selected) // deselecting a tile by clicking on the selected tile
        //{
        //    GameManager.Instance.board.ClearHighlightsAndTargets();
        //    selected = false;
        //}
        //else if (pieceOnTile.Steps > 0 && pieceOnTile.Team.Name.Equals(GameManager.whosTurn.Name)) // selecting a tile with steps
        //{
        //    if (GameManager.whosTurn.Energy > 0 || pieceOnTile.Steps != pieceOnTile.Speed)
        //    {
        //        HighlightAdjacent();
        //        TargetInRange();
        //        selected = true;
        //    }
        //}
        //else if (pieceOnTile.Team.Name.Equals(GameManager.whosTurn.Name) && !attacked) // selecting a tile without steps(just targeting)
        //{
        //    if (GameManager.whosTurn.Energy > 0)
        //    {
        //        TargetInRange();
        //        selected = true;
        //    }
        //}
    }


    //public void HighlightAdjacent() // sets the adjacent tiles to display a gray circle
    //{
    //    for (int i = -1; i <= 1; i++)
    //    {
    //        for (int j = -1; j <= 1; j++)
    //        {
    //            //  this horrid if statement prevents going out of bounds and prevents overriding the center's image
    //            if (i + posx <= 8 && i + posx >= 0 && j + posy <= 8 && j + posy >= 0 && !(i == 0 && j == 0))
    //            {
    //                Tile tile = GameManager.Instance.board.tiles[i + posx, j + posy];
    //                if (tile.pieceOnTile == null)
    //                {
    //                    tile.Highlight();
    //                    tile.CurrentlyControlingTile = this;
    //                }
    //            }
    //        }
    //    }
    //}
    //
    //public void Highlight() // highlights spaces you can move to
    //{
    //    highlighted = true;
    //    displayImage.enabled = true;
    //    Sprite sprite = Resources.Load<Sprite>(FilePaths.MoveCircle);
    //    displayImage.sprite = sprite;
    //}
    //
    //public void TargetInRange() // puts a target overlay above things you can attack
    //{
    //    if (pieceOnTile != null)
    //    {
    //        for (int i = -pieceOnTile.Range; i <= pieceOnTile.Range; i++)
    //        {
    //            for (int j = -pieceOnTile.Range; j <= pieceOnTile.Range; j++)
    //            {
    //                if (i + posx <= 8 && i + posx >= 0 && j + posy <= 8 && j + posy >= 0 && !(i == 0 && j == 0))
    //                {
    //                    Tile tile = GameManager.Instance.board.tiles[i + posx, j + posy];
    //                    if (tile.pieceOnTile != null)
    //                    {
    //                        tile.Target();
    //                        tile.CurrentlyControlingTile = this;
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}
    //
    //public void Target() // targets current space
    //{
    //    targeted = true;
    //    targetOverlay.enabled = true;
    //}
}
